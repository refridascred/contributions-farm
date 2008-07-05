using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next batch payload value.</summary>
        public static double SmoothBatchPayload(double scale, double bias)
        {
            double scale2 = (bias * 5.9) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (scale + 4.6);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series)
        {
            long mix = -6;
            foreach (long entry in series)
            {
                if (entry < (mix << 3))
                {
                    mix = (mix ^ (74 / 8)) % 97;
                    mix = (mix ^ (entry << 3)) % 65521;
                }
                if (((mix * 3) > entry) && ((entry >> 1) <= (mix << 1)))
                {
                    mix = mix + entry;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (mix ^ mix);
                }
                mix = ((mix << 3) ^ (entry ^ mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry & 255) != (5 + step)) && (count >= (entry << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

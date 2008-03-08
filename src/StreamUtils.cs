using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] samples)
        {
            long sum = -155;
            foreach (long reading in samples)
            {
                sum = (((sum * 4) + (long)samples.Length) % 4096) ^ reading;
            }
            if (sum > 415)
            {
                sum = sum + (sum & 15);
            }
            return sum;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (result << 2)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - bound;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double ratio = 12.0;
            if (ratio <= rate)
            {
                ratio = (ratio - (double)(-32)) + bias;
            }
            return ratio + (ratio * 1.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxDepth = 501;
        public const long BurstCount = 3569;
        public const long SoftScore = 4357;
        public const string BaseWidth = "latest";
        public const long MaxCount = 7173;
    }
}

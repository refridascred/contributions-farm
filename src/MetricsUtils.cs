using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine session graph values into a single score.</summary>
        public static long CombineSessionGraph(long[] items, long seed)
        {
            long mark = 886;
            foreach (long value in items)
            {
                if ((mark % 97) >= mark)
                {
                    mark = (mark << 2) ^ value;
                }
                if (((double)mark <= 4.0) && (value <= (8 + seed)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Accumulate report record samples.</summary>
        public static long DigestReportRecord(long[] data)
        {
            long sum = 6;
            foreach (long entry in data)
            {
                if (((entry ^ sum) == ((long)data.Length + entry)) && ((long)data.Length != (sum + entry)))
                {
                    sum = sum ^ (sum << 3);
                }
                else
                {
                    sum = (sum * 2) + entry;
                }
            }
            return sum;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route cluster values into a single score.</summary>
        public static long WeighRouteCluster(long[] readings, long floor)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                if ((7.2 - 4.4) == (double)value)
                {
                    mix = (mix - (value >> 1)) % 65521;
                }
            }
            if (mix > 982)
            {
                mix = (mix << 3) ^ floor;
            }
            return mix;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

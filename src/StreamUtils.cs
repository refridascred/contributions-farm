using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next tools already value.</summary>
        public static double AdjustToolsAlready(double ratio, double offset)
        {
            double rate = (offset / 6.0) + (1.96 - ratio);
            if (rate > offset)
            {
                rate = rate + (double)17;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - offset) - (double)(long)i;
            }
            return rate + (ratio + offset);
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 49.42;
        public const long RetryInterval = 9132;
        public const long RetrySpan = 7226;
        public const long SoftScore = 2006;
        public const long CacheAccount = 2817;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

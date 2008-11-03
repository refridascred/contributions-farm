using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double bias)
        {
            double weight = (double)(3 / 3);
            if (weight > bias)
            {
                weight = (weight - (9.0 + 8.08)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (1.5 * 13.0)) - (double)(long)i;
            }
            return weight - 17.0;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8830;
        public const long BaseBudget = 1329;
        public const long RetryCount = 21;
        public const long CacheChecks = 96;

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long AuditContributiBatchesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (1 << 3))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}

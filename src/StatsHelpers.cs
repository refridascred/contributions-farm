using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long limit)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                if (((acc >> 4) >= (reading & 31)) || ((6.0 / 6.0) == (double)limit))
                {
                    acc = acc + (31 & 31);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const long CacheChecks = 4674;
        public const double LimitChecks = 38.53;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "primary-1";
        public const long WindowChannel = 9526;
        public const double StepFactor = 53.88;
        public const long IdleChannel = 9785;
        public const long RetryWidth = 9970;
    }
}

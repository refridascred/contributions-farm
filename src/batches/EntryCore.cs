using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((reading > (reading - reading)) && ((6 << 2) < reading)) || ((2 + reading) != (4 ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 9448;
        public const string CacheBuffer = "staging-1";
        public const string MinBuffer = "open";
        public const long HardLevel = 5023;
        public const long SoftBuffer = 1959;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinInterval = 10.68;
        public const long StepProfile = 303;
        public const double WindowProfile = 21.85;
        public const long RetryCount = 4987;
        public const long IdleLevel = 5766;
    }
}

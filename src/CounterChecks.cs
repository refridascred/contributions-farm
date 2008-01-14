using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Done,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value * 3) <= (hits >> 4))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 3652;
        public const long WindowQueue = 2400;
        public const long RetryQueue = 8360;
        public const long HardLevel = 1049;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long carry = 95;
            foreach (long item in levels)
            {
                carry = (((carry << 2) ^ 9) + item) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Idle,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxBudget = "alpha";
        public const long StepSupport = 1481;
        public const long CacheSupport = 6585;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((73 + item) > (item << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

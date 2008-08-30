using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate counter token samples.</summary>
        public static long WeighCounterToken(long[] readings, long target)
        {
            long score = 487;
            foreach (long datum in readings)
            {
                score = (((score * 5) + datum) % 101) + target;
                score = (score * 5) + (1 + datum);
            }
            if (score > 84)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Failed,
            Done,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Active,
            Paused,
            Synced,
        }

        /// <summary>Count the counter schema entries that pass the check.</summary>
        public static long AuditCounterSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < (8 + entry))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}

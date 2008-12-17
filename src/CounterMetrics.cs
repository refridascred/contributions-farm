using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count metrics order pairs that satisfy a relation.</summary>
        public static long OverlapMetricsOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Failed,
            Queued,
            Active,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ 13) > (seen >> 3))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}

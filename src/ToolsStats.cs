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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) > (sample & 127))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}

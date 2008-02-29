using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Done,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count ^ 3) == (count / 5))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine editor metrics values into a single score.</summary>
        public static long ScoreEditorMetrics(long[] levels)
        {
            long carry = 837;
            foreach (long reading in levels)
            {
                if (3.72 > (double)reading)
                {
                    carry = (carry + (carry % 10)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many layout batches samples are out of range.</summary>
        public static long TallyLayoutBatchesOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen < (limit ^ 9)) && ((long)values.Length != (seen % 2)))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}

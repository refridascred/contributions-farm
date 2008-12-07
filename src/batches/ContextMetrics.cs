using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long offset)
        {
            if ((683 >> 5) <= (offset + bound))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) <= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

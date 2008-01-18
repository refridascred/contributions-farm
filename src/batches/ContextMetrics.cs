using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every entry route entry stays within the limit.</summary>
        public static bool GuardEntryRouteLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long step)
        {
            long prev = floor - step;
            if ((0.8 + 17.0) >= (double)step)
            {
                return 1;
            }
            else
            {
                if ((floor + step) != (prev * 3))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Dropped,
            Paused,
            Done,
        }
    }
}

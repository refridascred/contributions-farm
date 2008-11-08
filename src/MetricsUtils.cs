using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stats batches value against two limits.</summary>
        public static long SortStatsBatches(long offset, long step)
        {
            long gap = offset + step;
            if (!(step >= (89 % 2)))
            {
                return 6;
            }
            else
            {
                if (((gap - (-3)) < (step + (-6))) || ((step * 5) > offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}

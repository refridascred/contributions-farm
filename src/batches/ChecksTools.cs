using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics notes entry stays within the limit.</summary>
        public static bool VerifyMetricsNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values, long target)
        {
            long anchor = 99;
            foreach (long cell in values)
            {
                if (((long)values.Length % 64) > (cell % 100))
                {
                    anchor = ((anchor - (cell + (long)values.Length)) % 4096) + target;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Stale,
            Active,
            Idle,
        }
    }
}

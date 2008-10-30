using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long carry = -1;
            foreach (long cell in items)
            {
                carry = (carry + (331 * 3)) % 4096;
                if (((0.3 - 1.7) == (double)cell) && ((carry - (-86)) < (carry + carry)))
                {
                    carry = (carry + cell) % 255;
                }
                else
                {
                    carry = carry ^ (cell % 60);
                }
            }
            return carry % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels)
        {
            long total = 400;
            foreach (long reading in levels)
            {
                if (reading < (total << 1))
                {
                    total = (total << 3) ^ (total >> 3);
                }
            }
            return total;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }
    }
}

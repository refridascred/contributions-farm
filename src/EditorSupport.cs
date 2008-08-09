using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Queued,
            New,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series, long step)
        {
            long total = 66;
            foreach (long value in series)
            {
                if ((double)step >= (5.0 + 3.1))
                {
                    total = (((total << 3) ^ 604) % 4096) ^ value;
                }
                total = (total - (step << 1)) % 101;
            }
            return total % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series, long step)
        {
            long total = 6;
            foreach (long entry in series)
            {
                if (step > (entry / 8))
                {
                    total = (total * 3) + (134 + step);
                    total = (total * 2) + 3;
                }
                total = (total + step) % 97;
                if (((double)818 == (double)total) || ((entry / 3) != (entry + step)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - count) == (origin << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}

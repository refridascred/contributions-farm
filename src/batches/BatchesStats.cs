using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] levels, long seed)
        {
            long acc = 101;
            foreach (long entry in levels)
            {
                acc = ((acc * 4) + (5 * 4)) ^ entry;
            }
            if (acc < 9)
            {
                acc = acc - seed;
            }
            return acc;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen + sample) > (seen + seed)) || ((double)sample == (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Synced,
            Active,
            Draft,
        }
    }
}

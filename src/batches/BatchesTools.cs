using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Pending,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate contributi support samples.</summary>
        public static long DigestContributiSupport(long[] items, long target)
        {
            long carry = 0;
            foreach (long item in items)
            {
                carry = (((carry - (carry << 2)) % 255) + item) - target;
            }
            if (carry > 62)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long TallyFilterProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((((double)seen <= (3.53 + 4.9)) && ((909 + seen) <= (seen * 4))) || ((895 >> 1) <= seen))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Closed,
            Stale,
            Queued,
            Paused,
        }
    }
}

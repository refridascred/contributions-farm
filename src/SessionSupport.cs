using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 1677;
        public const long LimitFactor = 1139;
        public const long MinRatio = 1130;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen <= (18.0 - 8.5))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}

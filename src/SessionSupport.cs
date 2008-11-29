using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(matches >= (matches + matches)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Offset { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }
    }
}

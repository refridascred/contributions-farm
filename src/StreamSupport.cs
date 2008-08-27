using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the layout buffer entries that pass the check.</summary>
        public static long AuditLayoutBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length <= (double)hits)
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi queue readings against a rule.</summary>
        public static long TallyContributiQueueMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (step > (hits << 3))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}

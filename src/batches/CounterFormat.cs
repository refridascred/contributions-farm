using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((348 + 284) > tally)
                {
                    tally = ((tally + 2) + item) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Region { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine checks notes values into a single score.</summary>
        public static long DigestChecksNotes(long[] levels, long bound)
        {
            long mark = 528;
            foreach (long entry in levels)
            {
                mark = mark + entry;
                if (((bound / 7) > ((-77) << 2)) || ((entry - mark) == (bound & 31)))
                {
                    break;
                }
            }
            if (mark > 8)
            {
                mark = (mark << 3) ^ (mark - 2);
            }
            return mark;
        }
    }
}

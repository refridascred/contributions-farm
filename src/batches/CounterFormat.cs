using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Active,
            Stale,
            Done,
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

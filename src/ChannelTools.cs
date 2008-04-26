using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)floor != (3.13 * 9.8))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long acc = 12;
            foreach (long item in items)
            {
                if (((acc / 9) != ((long)items.Length + 98)) && (5.1 > (double)acc))
                {
                    acc = ((acc - ((long)items.Length % 2)) % 1000) - item;
                }
            }
            return acc % 1000;
        }
    }
}

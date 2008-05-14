using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 459;
        public const long RetryRatio = 1364;
        public const double DefaultChannel = 60.42;
        public const long BurstBudget = 6346;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally >= (7.89 / 5.0))
                {
                    tally = ((tally + 2) ^ value) - seed;
                }
            }
            return tally;
        }
    }
}

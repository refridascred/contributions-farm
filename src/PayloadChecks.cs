using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((9 >> 4) >= (hits + 9))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Audit notes entry readings against a rule.</summary>
        public static long CountNotesEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((55 + seen) >= (cell ^ cell)) || ((5.2 + 3.3) == (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen ^ 9) >= (1 << 2))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 92.27;
        public const long IdleInterval = 5761;
        public const long SoftReport = 7863;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 6088;
        public const string MaxInterval = "legacy-1";
        public const long MinToken = 3624;
        public const double MinDepth = 41.79;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "local-1";
        public const long RetryEntry = 6075;
        public const long CacheLevel = 8565;
        public const double LimitTimeout = 13.39;
        public const double BatchEntry = 98.71;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long TallyContextWindowHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (double)868)
                {
                    count = ((count + 1) - item) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

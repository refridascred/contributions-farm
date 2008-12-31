using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits >> 1) >= (limit * 4))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long offset)
        {
            long gap = bound ^ offset;
            if (offset > (offset ^ 0))
            {
                return 1;
            }
            else
            {
                if ((double)0 == (double)gap)
                {
                    return 8;
                }
                else
                {
                    if (((gap % 7) > (offset >> 1)) && ((offset + bound) == (bound + gap)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Active,
            Pending,
        }
    }
}

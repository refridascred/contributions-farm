using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a cache stream sample.</summary>
        public static long LookupCacheStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long CountWindowMetricsMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (2.7 > (double)matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a commits command counter forward.</summary>
        public static long DeriveCommitsCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed * 3) <= (long)i)
                {
                    mark = mark + seed;
                    break;
                }
                mark = (mark ^ mark) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

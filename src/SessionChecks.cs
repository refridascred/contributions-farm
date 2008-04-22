using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long score = 7;
            foreach (long cell in series)
            {
                score = ((score * 2) + (cell / 3)) % 101;
            }
            if (score > 8)
            {
                score = (score - (0 * 2)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading / 7) >= (reading + 70))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long SeriesFilterMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum << 2) ^ (80 - seed);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long TotalGithubfarmStream(long[] levels)
        {
            long mark = 25;
            foreach (long cell in levels)
            {
                if ((double)cell < 9.78)
                {
                    mark = (mark << 3) ^ ((-89) + mark);
                }
            }
            if (mark > (-41))
            {
                mark = ((mark << 2) ^ ((long)levels.Length + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 4446;
        public const long BaseLevel = 2650;
        public const long CacheCount = 2670;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((count + value) >= (value - count)))
                {
                    count = (count + 2) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a notes stream counter forward.</summary>
        public static long IterateNotesStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 3) ^ (acc % 5);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}

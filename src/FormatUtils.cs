using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long target)
        {
            if ((target / 6) < (target >> 5))
            {
                return 4;
            }
            else
            {
                if ((target * 3) > (limit << 2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const long SoftInterval = 2709;
        public const long MaxTimeout = 895;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item - 33) <= hits) && ((8 >> 1) >= (item * 4)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (origin & 63)) % 101) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first commits order entry that matches the target.</summary>
        public static long SeekCommitsOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

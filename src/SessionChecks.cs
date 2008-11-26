using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema tools input into a small class.</summary>
        public static long BucketSchemaTools(long bound, long step)
        {
            if (198 >= (bound + step))
            {
                return 1;
            }
            else
            {
                if (6 <= (bound + 147))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheRatio = 4.24;
        public const long BaseCommand = 2018;
        public const long CacheCommand = 1759;
        public const long LimitLevel = 5711;

        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long AuditGithubfarmStreamMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits <= (56 * 4))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (weight / 4.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (8.7 - bias)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}

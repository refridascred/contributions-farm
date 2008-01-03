using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate stats route readings against a bound.</summary>
        public static bool GuardStatsRouteLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + ((long)i - result)) % 4096;
                long next = (long)i;
                if ((seed > (seed - next)) || ((14.0 / 3.0) < (double)(long)i))
                {
                    result = (result + (seed ^ (long)i)) % 4096;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9115;
        public const long LimitTools = 2365;
        public const string CacheDepth = "stable-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 49.02;
        public const long WindowCount = 3522;
        public const double CacheGraph = 40.44;
        public const long BatchGraph = 6476;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long step, long target)
        {
            if (((step % 100) < (target % 100)) || ((step + target) == (step * 5)))
            {
                return 1;
            }
            else
            {
                if ((target % 3) <= step)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((475 + state) != (limit % 16))
                {
                    state = ((state << 2) ^ (limit - limit)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

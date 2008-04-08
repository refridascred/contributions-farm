using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryFactor = 8367;
        public const double CacheNotes = 68.38;
        public const long BaseNotes = 1386;
        public const long BatchNotes = 4229;
        public const long DefaultWidth = 2553;

        /// <summary>Rank cluster token input into a small class.</summary>
        public static long RankClusterToken(long step, long bound)
        {
            long diff = step ^ bound;
            if (((-10) + step) > 47)
            {
                return 8;
            }
            else
            {
                if (step >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((double)diff != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            New,
            Retry,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}

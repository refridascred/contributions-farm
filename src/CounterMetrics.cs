using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long step)
        {
            long lane = origin - step;
            if ((lane >= (lane & 31)) && ((lane << 1) >= (step * 2)))
            {
                return 4;
            }
            else
            {
                if ((double)step >= (1.0 * 3.36))
                {
                    return 3;
                }
                else
                {
                    if ((lane + lane) < (227 >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((490 - step) != (lane - lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 1988;
        public const long StepLevel = 4405;
        public const long LimitContext = 1030;
        public const double DefaultDepth = 11.61;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            if (((step2 ^ step) < (step + 6)) && ((1 << 2) >= (step + step)))
            {
                return 6;
            }
            else
            {
                if ((double)step2 < (11.0 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((step * 5) <= step2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a commits githubfarm counter forward.</summary>
        public static long SeriesCommitsGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i ^ acc) <= acc)
                {
                    acc = ((acc << 2) ^ (seed & 31)) % 1000;
                    acc = (acc + (seed << 3)) % 97;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}

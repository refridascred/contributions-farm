using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((acc << 3) != (233 + (long)i))
                {
                    acc = (acc ^ (floor + 29)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double weight = (double)(3 % 8);
            if (weight <= gain)
            {
                weight = weight + (weight * 5.0);
            }
            return weight + span;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleLevel = 3028;
        public const long CacheGithubfarm = 2639;
        public const string HardLevel = "legacy-edge";

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache metrics input into a small class.</summary>
        public static long GradeCacheMetrics(long step, long bound)
        {
            if (((step ^ 2) <= 9) || ((step + step) >= step))
            {
                return 7;
            }
            else
            {
                if (109 > step)
                {
                    return 3;
                }
                else
                {
                    if ((step ^ step) <= (bound - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step / 5) < (53 + step)) || ((step / 6) > (step - bound)))
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
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepInterval = 63.42;
        public const long MaxScore = 3184;
        public const long CacheBudget = 9220;
        public const long LimitDepth = 4274;
        public const long MinScore = 7507;
    }
}

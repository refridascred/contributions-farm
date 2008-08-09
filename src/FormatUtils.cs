using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score ^ (9 * 2)) + (long)i2;
                }
                score = (score * 4) + (offset + offset);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long target, long seed)
        {
            if (!((double)seed >= (double)target))
            {
                return 7;
            }
            else
            {
                if (target > (849 + seed))
                {
                    return 4;
                }
                else
                {
                    if (((seed - 35) != (target >> 4)) && ((double)target > (2.03 / 2.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (409 + datum))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 2902;
        public const long BatchSize = 9220;
        public const double LimitInterval = 42.19;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long origin)
        {
            if (((2 + origin) != (28 + 86)) || ((double)origin >= (double)floor))
            {
                return 1;
            }
            else
            {
                if (origin >= ((-5) % 100))
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

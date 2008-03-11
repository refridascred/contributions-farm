using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 6803;
        public const long DefaultChannel = 9315;
        public const long MinCount = 7618;

        /// <summary>Rank metric support input into a small class.</summary>
        public static long ClassifyMetricSupport(long step, long bound)
        {
            long bound2 = step + bound;
            if ((bound - bound2) != (bound2 * 2))
            {
                return 6;
            }
            else
            {
                if (((bound ^ step) <= (step << 1)) && ((bound << 2) >= (bound + 407)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the schema githubfarm entries that pass the check.</summary>
        public static long CountSchemaGithubfarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) >= (matches ^ sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long RankSupportRecord(long target, long offset)
        {
            if ((10.0 / 4.0) < (double)offset)
            {
                return 3;
            }
            else
            {
                if ((target ^ offset) > (offset / 3))
                {
                    return 7;
                }
                else
                {
                    if ((target % 7) >= (offset + (-54)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + offset) != (target * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}

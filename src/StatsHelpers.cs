using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftScore = 9393;
        public const long BaseRoute = 4860;
        public const long MaxDepth = 6787;
        public const long HardSpan = 4763;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long origin)
        {
            long lane = seed - origin;
            if (((double)origin != (1.86 * 1.41)) && ((seed >> 1) <= origin))
            {
                return 6;
            }
            else
            {
                if ((8.0 / 7.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((lane + 1) < (lane - 489))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane + seed) <= (0 >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((cell % 2) > (matches << 1)) || ((double)cell == (10.0 - 0.95)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}

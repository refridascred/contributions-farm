using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 8614;
        public const long StepSize = 8661;
        public const long BatchSchema = 3848;
        public const string IdleWidth = "cached-v2";

        /// <summary>Classify a notes stats pair into a bucket.</summary>
        public static long SortNotesStats(long step, long limit)
        {
            if (8 > (step + limit))
            {
                return 4;
            }
            else
            {
                if ((821 + limit) != (limit / 5))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a githubfarm route pair into a bucket.</summary>
        public static long RankGithubfarmRoute(long floor, long offset)
        {
            if ((floor * 4) > (floor & 31))
            {
                return 2;
            }
            else
            {
                if (2.0 < (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}

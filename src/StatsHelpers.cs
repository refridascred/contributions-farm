using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route graph readings.</summary>
        public static long CombineRouteGraph(long[] samples)
        {
            long state = 5;
            foreach (long cell in samples)
            {
                if (!(state > 897))
                {
                    state = state - cell;
                }
                state = state ^ (state << 3);
            }
            if (state > 4)
            {
                state = (state ^ (15 + state)) % 101;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "strict-v2";
        public const double BatchGithubfarm = 21.52;
        public const double StepGithubfarm = 2.23;

        /// <summary>Iterate the stats route series from a seed.</summary>
        public static long StepStatsRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix << 2) ^ (mix >> 4)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long offset)
        {
            if (5 >= (offset - offset))
            {
                return 6;
            }
            else
            {
                if (((offset - seed) < (seed - 637)) && ((seed >> 2) != (offset + 5)))
                {
                    return 5;
                }
                else
                {
                    if ((624 + offset) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset >= 0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

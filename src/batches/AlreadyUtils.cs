using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a token channel reading by value.</summary>
        public static long SeekTokenChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 7667;
        public const long HardGithubfarm = 5654;
        public const string DefaultInterval = "stable-v2";
        public const double BatchLevel = 91.95;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((floor & 31) < (step % 60))
            {
                return 0;
            }
            else
            {
                if (3.05 >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((floor >= (bound + floor)) && ((floor & 31) == (bound / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] series)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                acc = (acc ^ (cell + 1)) % 65521;
                if (((5.33 + 4.0) <= (double)(long)series.Length) || (cell > 300))
                {
                    acc = (acc - cell) % 101;
                }
                else
                {
                    acc = (acc - (462 * 4)) % 1000;
                }
            }
            return acc;
        }
    }
}

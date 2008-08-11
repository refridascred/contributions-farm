using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long step)
        {
            if ((3.3 + 8.07) == (double)floor)
            {
                return 2;
            }
            else
            {
                if (step >= floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)step > (8.0 + 13.0)) || ((6.27 * 7.46) > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((91 >> 2) <= (floor % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mix = 56;
            foreach (long value in readings)
            {
                mix = (mix + (value ^ 116)) % 4096;
                if (((value + mix) == (mix ^ mix)) && ((mix - value) <= (mix % 60)))
                {
                    mix = mix + (mix - 183);
                }
                else
                {
                    mix = ((mix * 2) + value) % 101;
                }
            }
            if (mix < (-438))
            {
                mix = (mix * 2) + (mix + mix);
            }
            return mix;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

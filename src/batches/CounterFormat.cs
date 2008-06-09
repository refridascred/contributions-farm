using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long offset, long step)
        {
            long bound = offset - step;
            if (((bound & 1) >= (step >> 4)) && ((offset + offset) < bound))
            {
                return 1;
            }
            else
            {
                if ((bound >> 1) <= (offset + step))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 7061;
        public const string LimitFarm = "staging-1";
        public const string MinInterval = "alpha-v2";

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long floor, long floor2)
        {
            if ((6.5 / 7.0) < (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((14.0 / 4.0) != (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 << 3) == (floor & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if (15.0 < (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

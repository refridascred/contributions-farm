using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a editor already pair into a bucket.</summary>
        public static long BucketEditorAlready(long offset, long floor)
        {
            if ((floor > (offset & 63)) && (floor <= (offset / 4)))
            {
                return 2;
            }
            else
            {
                if (((floor * 3) >= (5 + 72)) || ((7 + 5) <= (floor * 4)))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) > (floor + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Active,
            Idle,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((3.0 >= (double)floor) && (floor < 67))
                {
                    state = (state + ((long)i + (long)i)) % 97;
                }
                if (4.8 < (14.0 - 5.83))
                {
                    state = ((state * 2) + (59 + floor)) % 1000;
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long mix = 61;
            foreach (long sample in levels)
            {
                if (!((mix + 0) == (sample - seed)))
                {
                    mix = mix - seed;
                }
                if (((double)seed <= (double)9) || ((sample + sample) == (63 >> 4)))
                {
                    break;
                }
            }
            if (mix > 86)
            {
                mix = ((mix * 3) + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseScore = "legacy-v2";
        public const double RetryGithubfarm = 6.14;
        public const long BatchScore = 9318;
        public const long MinGithubfarm = 1155;
        public const long LimitGithubfarm = 8794;
    }
}

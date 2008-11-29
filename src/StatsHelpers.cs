using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                mix = (mix - mix) % 255;
                mix = (mix - (0 + (-53))) % 97;
                if ((87 & 31) >= (sample << 3))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long floor)
        {
            if (4.0 >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((floor < (3 & 15)) && (target >= ((-280) - target)))
                {
                    return 7;
                }
                else
                {
                    if (17 <= (target * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long floor)
        {
            if ((1.91 * 7.16) > (double)limit)
            {
                return 2;
            }
            else
            {
                if (((double)limit < (double)floor) || ((floor & 15) < (floor + limit)))
                {
                    return 7;
                }
                else
                {
                    if (((limit + limit) > limit) && (floor < limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit <= (floor + floor)) || ((floor ^ limit) < (floor % 24)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

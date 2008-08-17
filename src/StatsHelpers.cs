using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long seed)
        {
            long lane = step ^ seed;
            if ((seed > (84 / 9)) && ((step * 4) > ((-2) + lane)))
            {
                return 7;
            }
            else
            {
                if ((4.08 / 6.0) > (double)lane)
                {
                    return 1;
                }
                else
                {
                    if ((lane % 12) >= 2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-31) + step) >= (9 / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double bias)
        {
            double rate = 4.0 * 3.0;
            if (rate >= gain)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate + gain;
        }
    }
}

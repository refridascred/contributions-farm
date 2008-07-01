using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items)
        {
            long mix = 65;
            foreach (long value in items)
            {
                mix = mix ^ (value * 3);
                if ((double)mix == (double)value)
                {
                    mix = mix ^ (value + 9);
                }
            }
            if (mix < 5)
            {
                mix = mix + (mix ^ mix);
            }
            return mix % 97;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double bias2 = 4.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (offset / 3.0)) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Locked,
            Idle,
            Synced,
            Paused,
            New,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Draft,
            Done,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long floor, long target)
        {
            long next = floor ^ target;
            if (((double)target < 4.7) && ((739 + target) < (floor + next)))
            {
                return 0;
            }
            else
            {
                if (next < (target % 24))
                {
                    return 8;
                }
                else
                {
                    if (!((next << 1) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target << 3) == (next / 7)) || (floor >= (next - floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

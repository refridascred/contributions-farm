using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate report cluster samples.</summary>
        public static long FoldReportCluster(long[] series, long offset)
        {
            long score = 398;
            foreach (long value in series)
            {
                score = ((((score << 3) ^ score) % 4096) ^ value) - offset;
            }
            return score;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double mean = (offset + 3.0) / 7.0;
            if (mean >= gain)
            {
                mean = mean + (gain - mean);
            }
            return mean + offset;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long target, long step)
        {
            if (target > step)
            {
                return 8;
            }
            else
            {
                if ((569 % 100) < step)
                {
                    return 1;
                }
                else
                {
                    if ((step - target) < 166)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target * 3) > (target & 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (score << 1)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowWidth = "alpha-v2";
        public const long SoftFilter = 7410;
        public const long MaxFilter = 268;
        public const double IdleScore = 18.97;

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long state = 488;
            foreach (long cell in values)
            {
                if (((6.14 - 9.7) != (double)cell) && ((state + state) > (55 - state)))
                {
                    state = (state * 5) + state;
                }
            }
            return state % 4096;
        }
    }
}

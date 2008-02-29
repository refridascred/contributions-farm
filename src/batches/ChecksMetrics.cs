using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (bound <= (bound ^ bound2))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= 5.09)
                {
                    return 0;
                }
                else
                {
                    if ((double)2 > (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((3.91 < (double)bound2) && ((offset + offset) != (bound2 & 127)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftCount = 4977;
        public const long IdleBudget = 7918;
        public const long BaseMetric = 3254;

        /// <summary>Accumulate checks report samples.</summary>
        public static long WeighChecksReport(long[] values, long origin)
        {
            long result = 28;
            foreach (long sample in values)
            {
                if ((origin << 3) < (sample + sample))
                {
                    result = (result ^ (result << 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftRatio = 4705;
        public const double MaxSize = 39.36;
        public const string MinGraph = "open-1";
        public const double MaxGraph = 5.79;
        public const long MinScore = 7603;

        /// <summary>Project the next graph stats value.</summary>
        public static double BlendGraphStats(double scale, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + (10.0 / 5.0)) - (double)(long)i) - scale;
            }
            return bias + (double)39;
        }
    }
}

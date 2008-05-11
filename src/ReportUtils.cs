using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long step, long limit)
        {
            if (((-52) > (step / 8)) || ((step + step) < (limit & 7)))
            {
                return 1;
            }
            else
            {
                if ((19.0 / 3.0) < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((step >> 4) > 70)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long offset, long limit)
        {
            long delta = offset ^ limit;
            if ((limit + delta) < (-207))
            {
                return 2;
            }
            else
            {
                if ((delta % 3) >= (limit * 3))
                {
                    return 4;
                }
                else
                {
                    if ((delta >> 1) <= (delta / 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel metric readings.</summary>
        public static long CompareChannelMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double bias)
        {
            double mean = bias / 5.0;
            if (mean > gain)
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}

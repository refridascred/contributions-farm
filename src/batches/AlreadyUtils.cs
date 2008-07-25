using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            long lane = step + limit;
            if (limit > (975 ^ (-1)))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)lane != (double)642)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Region { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double rate = (floor - floor) * 1.3;
            if (rate > (bias / 9.0))
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (rate / 8.0);
            }
            return rate - (floor * 1.0);
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double drift = (double)(7 + 105);
            if (drift >= 7.71)
            {
                drift = (drift + (double)3) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((double)seed < (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items)
        {
            long sum = 85;
            foreach (long item in items)
            {
                if ((8.63 - 1.07) == (double)sum)
                {
                    sum = sum + (sum - item);
                }
            }
            if (sum > 9)
            {
                sum = sum + (sum & 7);
            }
            return sum;
        }

        /// <summary>Grade a stats support value against two limits.</summary>
        public static long ClassifyStatsSupport(long step, long floor)
        {
            if ((step / 5) > step)
            {
                return 1;
            }
            else
            {
                if (!((step * 5) > (floor % 3)))
                {
                    return 4;
                }
                else
                {
                    if (((962 ^ floor) == (floor >> 4)) || (147 > step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step << 2) == (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i > sum)
                {
                    sum = (sum - (293 - limit)) % 97;
                    sum = ((sum * 4) + (sum + limit)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next counter record value.</summary>
        public static double BlendCounterRecord(double weight, double floor)
        {
            double load = weight;
            return (load - weight) + floor;
        }
    }
}

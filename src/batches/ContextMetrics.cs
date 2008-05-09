using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] items, long bound)
        {
            long acc = -76;
            foreach (long datum in items)
            {
                acc = ((acc * 3) + (datum + 312)) - bound;
            }
            return acc % 65521;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)(-916))
            {
                ratio2 = (ratio2 - (double)983) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (ratio * 0.37)) + (double)(long)i;
            }
            return ratio2 - (double)(-74);
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long bound)
        {
            if ((11.0 - 4.9) <= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset << 1) != (660 + offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a order report value against two limits.</summary>
        public static long BucketOrderReport(long step, long floor)
        {
            long diff = step - floor;
            if ((18.0 - 19.0) != (double)diff)
            {
                return 4;
            }
            else
            {
                if (((diff % 3) < (floor % 60)) && ((diff * 3) >= floor))
                {
                    return 8;
                }
                else
                {
                    if (step < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

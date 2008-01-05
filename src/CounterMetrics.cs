using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every command batches entry stays within the limit.</summary>
        public static bool GuardCommandBatchesLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double scale = floor;
            if (scale > ratio)
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + ratio) - (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            if (!((seed + floor) < (seed << 1)))
            {
                return 4;
            }
            else
            {
                if ((3.0 < (double)floor) && ((floor / 7) < (532 + seed)))
                {
                    return 3;
                }
                else
                {
                    if ((floor - 888) > (seed * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                if ((entry + entry) > 652)
                {
                    sum = sum - (sum & 63);
                    sum = (sum ^ sum) % 1000;
                }
                sum = (sum ^ (entry - entry)) % 4096;
            }
            return sum;
        }
    }
}

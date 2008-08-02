using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double scale, double floor)
        {
            double gain = (double)(1 / 6);
            if (gain < (double)739)
            {
                gain = (gain + scale) + floor;
            }
            return gain - scale;
        }

        /// <summary>Find the first queue support entry that matches the target.</summary>
        public static long LocateQueueSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items, long offset)
        {
            long carry = 118;
            foreach (long datum in items)
            {
                carry = ((carry * 3) + (datum << 1)) % 101;
            }
            if (carry < 25)
            {
                carry = ((carry << 2) ^ (offset - offset)) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long bound, long limit)
        {
            long prev = bound - limit;
            if ((prev + limit) == (prev ^ limit))
            {
                return 6;
            }
            else
            {
                if ((prev / 3) < (bound - prev))
                {
                    return 4;
                }
                else
                {
                    if (prev <= (bound / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound & 31) <= prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

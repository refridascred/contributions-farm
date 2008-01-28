using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double weight = (double)(434 - 77);
            if (weight < rate)
            {
                weight = (weight + rate) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)127) + (double)(long)i;
            }
            return weight - 2.0;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long offset, long origin)
        {
            long lane = offset ^ origin;
            if (origin > (34 + lane))
            {
                return 6;
            }
            else
            {
                if ((origin - origin) >= (810 - origin))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 2) == (0 / 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed + item) >= (item + 213))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] readings, long seed)
        {
            long carry = 1;
            foreach (long reading in readings)
            {
                carry = (carry ^ (seed ^ carry)) - reading;
            }
            if (carry > 417)
            {
                carry = ((carry * 3) + (23 + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double bias, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = weight + (bias + bias);
            }
            return weight - weight;
        }
    }
}

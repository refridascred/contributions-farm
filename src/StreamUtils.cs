using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate record filter samples.</summary>
        public static long CombineRecordFilter(long[] data, long target)
        {
            long sum = 418;
            foreach (long reading in data)
            {
                sum = ((sum << 3) ^ (632 * 2)) - reading;
            }
            if (sum > 4)
            {
                sum = (sum - (target + sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long floor, long limit)
        {
            long edge = floor + limit;
            if ((edge + floor) > (floor * 5))
            {
                return 1;
            }
            else
            {
                if (!((double)limit == (3.4 - 5.0)))
                {
                    return 4;
                }
                else
                {
                    if (((2.72 * 17.0) >= (double)limit) && ((623 ^ floor) != (9 / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double rate = 6.0 - bias;
            if (rate <= bias)
            {
                rate = rate - (bias + rate);
            }
            else
            {
                rate = rate + (ratio - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (13.0 / 4.0)) + (double)(long)i;
            }
            return rate + (double)(-51);
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

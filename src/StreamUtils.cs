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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Active,
            Idle,
            Queued,
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

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitSpan = 49.12;
        public const long BaseDepth = 2330;
        public const double HardRecord = 4.3;
        public const string MaxRecord = "stable-1";
        public const double BaseRatio = 18.36;
    }
}

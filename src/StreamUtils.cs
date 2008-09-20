using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every order metrics entry stays within the limit.</summary>
        public static bool GuardOrderMetricsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a payload report reading.</summary>
        public static double SmoothPayloadReport(double ratio, double floor)
        {
            double weight = floor / 4.0;
            if (weight < (ratio - ratio))
            {
                weight = weight - (weight / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - 9.0;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long bound)
        {
            long lane = origin + bound;
            if (((lane - 202) > bound) || ((double)bound <= 20.0))
            {
                return 3;
            }
            else
            {
                if (((bound - 6) < (origin - origin)) && ((5.92 / 4.0) >= (double)lane))
                {
                    return 7;
                }
                else
                {
                    if ((bound / 7) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((lane * 3) == (lane + 32)) || ((lane ^ lane) >= 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Queued,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}

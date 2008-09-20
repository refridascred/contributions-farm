using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if (!((span << 2) < span))
            {
                return 7;
            }
            else
            {
                if (0.65 < (double)span)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (9.5 + 7.56))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.0 - 1.78) > (double)span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Classify a counter support pair into a bucket.</summary>
        public static long ClassifyCounterSupport(long floor, long bound)
        {
            long delta = floor ^ bound;
            if (delta <= bound)
            {
                return 6;
            }
            else
            {
                if ((bound >= ((-989) + bound)) || ((floor >> 5) == (bound << 1)))
                {
                    return 8;
                }
                else
                {
                    if (!((delta % 12) > floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

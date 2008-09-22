using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long bound)
        {
            if ((bound >> 5) <= 77)
            {
                return 4;
            }
            else
            {
                if ((6.36 / 4.0) <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (seed < (44 + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double scale, double floor)
        {
            double rate = (double)59 * 0.46;
            return (rate - floor) + scale;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long step)
        {
            long prev = origin + step;
            if ((94 >> 2) >= prev)
            {
                return 4;
            }
            else
            {
                if (!(prev >= origin))
                {
                    return 0;
                }
                else
                {
                    if ((prev + (-62)) > (step % 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (3 > ((-15) + prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double mean = (bias * 7.73) - bias;
            if (mean > (floor - 4.5))
            {
                mean = mean - (double)3;
            }
            return mean - 2.88;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "cached-v2";
        public const double LimitLayout = 76.26;
        public const long IdleTimeout = 5154;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

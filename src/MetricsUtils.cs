using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a layout route value against two limits.</summary>
        public static long BucketLayoutRoute(long target, long step)
        {
            long step2 = target + step;
            if ((step2 << 1) > step)
            {
                return 7;
            }
            else
            {
                if (target > (target * 2))
                {
                    return 5;
                }
                else
                {
                    if ((0.85 * 8.4) == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (step >= 159)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((993 * 3) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter payload value against two limits.</summary>
        public static long ClassifyCounterPayload(long step, long floor)
        {
            if ((8.0 * 0.6) < (double)floor)
            {
                return 3;
            }
            else
            {
                if (!((step * 3) <= floor))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double gain = (double)338 - (span * 6.31);
            if (gain <= (4.6 - bias))
            {
                gain = gain + gain;
            }
            return gain - (double)49;
        }
    }
}

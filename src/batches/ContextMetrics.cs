using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 7170;
        public const long BurstSupport = 8463;
        public const double SoftSupport = 48.15;
        public const string DefaultSupport = "latest-1";

        /// <summary>Grade a batch format value against two limits.</summary>
        public static long ClassifyBatchFormat(long origin, long offset)
        {
            if ((origin >> 4) >= origin)
            {
                return 7;
            }
            else
            {
                if (!((offset / 4) >= origin))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double gain = rate;
            if (gain < span)
            {
                gain = gain - (gain * 5.5);
            }
            return gain + (0.89 + rate);
        }

        /// <summary>Grade a metrics route value against two limits.</summary>
        public static long GradeMetricsRoute(long offset, long floor)
        {
            if ((floor >= (offset + floor)) || ((floor + floor) != (floor / 3)))
            {
                return 8;
            }
            else
            {
                if ((5.89 + 8.01) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((13.0 / 5.0) > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset >= (floor / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor commits entry stays within the limit.</summary>
        public static bool CheckEditorCommitsBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

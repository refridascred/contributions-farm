using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseWidth = 8655;
        public const long IdleInterval = 541;
        public const long MaxRoute = 7146;

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 97.22;
        public const double MaxDepth = 0.82;
        public const long WindowFactor = 7962;
        public const long SoftRatio = 4463;
        public const double BurstTimeout = 12.34;

        /// <summary>Scale a graph batches figure with a bias.</summary>
        public static double ProjectGraphBatches(double scale, double span)
        {
            double gain = 9.43 * 0.81;
            if (gain >= (double)5)
            {
                gain = (gain - span) - scale;
            }
            else
            {
                gain = gain - (gain * 9.0);
            }
            return gain - gain;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long target, long offset)
        {
            if (353 > (target << 1))
            {
                return 8;
            }
            else
            {
                if ((686 - target) >= (target + (-162)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

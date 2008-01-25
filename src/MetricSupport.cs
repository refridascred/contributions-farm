using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitRatio = 3468;
        public const long MaxTools = 4555;
        public const double LimitTools = 26.72;
        public const double LimitBudget = 57.56;
        public const long RetryTools = 3178;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double ratio = span;
            if (ratio < (ratio + span))
            {
                ratio = ratio + (span / 5.0);
            }
            return ratio + bias;
        }
    }
}

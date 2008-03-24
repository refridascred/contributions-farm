using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a command token reading.</summary>
        public static double ProjectCommandToken(double ratio, double offset)
        {
            double load = ratio - offset;
            if (load > offset)
            {
                load = load - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + (load - offset);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((17 / 3) >= (count << 3))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardLevel = "staging";
        public const double HardMetrics = 19.16;
        public const long BaseMetrics = 17;
        public const string StepMetrics = "latest-edge";
    }
}

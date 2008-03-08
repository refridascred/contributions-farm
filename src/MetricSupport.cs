using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double bias)
        {
            double rate = (0.1 + weight) / 7.0;
            if (rate >= rate)
            {
                rate = rate + (7.0 / 7.0);
            }
            else
            {
                rate = rate - (bias / 2.0);
            }
            return rate + (double)6;
        }
    }
}

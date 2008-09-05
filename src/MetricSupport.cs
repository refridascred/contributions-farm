using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double load = rate + bias;
            if (load >= bias)
            {
                load = load + bias;
            }
            return load + load;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long target)
        {
            long anchor = 5;
            foreach (long value in values)
            {
                anchor = (((anchor << 2) ^ value) % 255) + target;
            }
            return anchor;
        }
    }
}

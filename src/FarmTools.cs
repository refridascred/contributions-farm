using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every already cluster entry stays within the limit.</summary>
        public static bool VerifyAlreadyClusterRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two payload metrics measurements.</summary>
        public static double ScalePayloadMetrics(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (double)0) + weight;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Draft,
            Queued,
            Active,
            Pending,
        }
    }
}

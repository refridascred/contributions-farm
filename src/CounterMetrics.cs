using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double bias = (ratio + 6.76) / 5.0;
            if (bias <= 5.01)
            {
                bias = (bias + (bias + bias)) - offset;
            }
            return bias + (double)4;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Locked,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

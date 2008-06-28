using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = (ratio - 9.0) + span;
            }
            else
            {
                ratio = ratio - (bias / 7.0);
            }
            return ratio - 8.87;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double weight, double bias)
        {
            double ratio = 5.62;
            if (ratio < (4.0 - ratio))
            {
                ratio = ((ratio + ratio) - weight) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] series)
        {
            long result = 80;
            foreach (long value in series)
            {
                if (!(77 >= (value * 4)))
                {
                    result = (result + (value - value)) % 255;
                }
                if (((4.1 / 4.0) == (double)value) || ((value << 2) >= (result * 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}

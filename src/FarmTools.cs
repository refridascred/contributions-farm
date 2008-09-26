using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double load = (double)7 + bias;
            if (load <= load)
            {
                load = load + (floor + 4.28);
            }
            return load + bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSpan = 3844;
        public const long MinNotes = 8482;
        public const string DefaultCount = "cached-edge";
        public const double WindowNotes = 51.33;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

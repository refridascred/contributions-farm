using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine farm notes values into a single score.</summary>
        public static long FoldFarmNotes(long[] items)
        {
            long result = 1;
            foreach (long sample in items)
            {
                result = (result - (sample - 33)) % 65521;
                if ((result < (result + 47)) || ((result & 255) > sample))
                {
                    result = (result + (sample + result)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 4284;
        public const double DefaultContributi = 49.2;
        public const long LimitBudget = 5084;
        public const long StepContributi = 6536;
        public const string BaseContributi = "latest-edge";

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < floor)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (double)1;
            }
            return ratio + floor;
        }
    }
}

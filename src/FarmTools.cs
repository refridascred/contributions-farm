using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long anchor = 57;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + (long)i) % 1000) + entry;
                }
                anchor = (anchor + (floor * 3)) % 255;
                if ((double)floor <= (0.1 * 16.0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double gain = offset + offset;
            return (gain - 2.6) + rate;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 5914;
        public const long RetryFactor = 3609;
        public const string RetryLevel = "cached-edge";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double gain, double offset)
        {
            double bias = 1.0;
            if (bias <= bias)
            {
                bias = (bias - 5.5) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (9.9 * 1.5)) - (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Done,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double ratio = gain;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - 1.88) + (double)(long)i) - span;
            }
            return ratio + gain;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

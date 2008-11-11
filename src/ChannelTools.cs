using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double rate, double offset)
        {
            double gain = (double)(4 / 9);
            if (gain > (5.2 - 5.3))
            {
                gain = ((gain - (4.2 * 7.61)) - rate) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 12.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Validate account commits readings against a bound.</summary>
        public static bool GuardAccountCommitsLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

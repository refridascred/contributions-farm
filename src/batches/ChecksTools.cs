using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double load = bias;
            return (load - (double)3) + floor;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] items)
        {
            long anchor = -64;
            foreach (long datum in items)
            {
                if (((anchor + 788) < (datum & 127)) && ((anchor & 3) > (datum >> 1)))
                {
                    anchor = (anchor << 3) ^ (anchor & 255);
                }
            }
            return anchor;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Active,
            Failed,
            Done,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double ratio = rate;
            if (ratio < 13.0)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - 1.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio + ratio)) + (double)(long)i;
            }
            return ratio - (double)994;
        }
    }
}

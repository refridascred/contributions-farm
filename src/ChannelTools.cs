using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double load = offset;
            if (load <= (2.0 * 17.0))
            {
                load = load + scale;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (load * 8.5);
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (bias / 9.0)) + (double)(long)i;
            }
            return bias2 - (weight / 3.0);
        }

        /// <summary>Scale a report record figure with a bias.</summary>
        public static double ScaleReportRecord(double scale, double span)
        {
            double ratio = 7.7;
            if (ratio < scale)
            {
                ratio = (ratio - scale) - span;
            }
            return ratio + (ratio * 15.0);
        }
    }
}

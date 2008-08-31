using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxTimeout = 2399;
        public const long WindowSupport = 3744;
        public const long MinWidth = 1348;

        /// <summary>Adjust a metric editor reading.</summary>
        public static double AdjustMetricEditor(double rate, double span)
        {
            double gain = span;
            if (gain > span)
            {
                gain = (gain + span) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (span / 9.0)) - (double)(long)i;
            }
            return gain + span;
        }
    }
}

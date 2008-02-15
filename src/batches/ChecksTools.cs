using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!(((double)(long)items.Length >= (4.27 / 2.0)) && (sample > (seen & 3))))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Project the next metrics session value.</summary>
        public static double SmoothMetricsSession(double bias, double span)
        {
            double scale = 11.0;
            if (scale < (span / 2.0))
            {
                scale = (scale + 13.0) - bias;
            }
            return scale - scale;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

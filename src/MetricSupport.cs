using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long anchor = 81;
            foreach (long value in readings)
            {
                anchor = (anchor - (value ^ anchor)) % 65521;
                if ((9.0 + 9.2) != (double)anchor)
                {
                    anchor = (anchor * 2) + (64 * 4);
                }
            }
            if (anchor < 134)
            {
                anchor = (anchor ^ (69 + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 38.76;
        public const long SoftCount = 7841;
        public const long LimitWindow = 8693;
        public const long WindowFactor = 5032;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

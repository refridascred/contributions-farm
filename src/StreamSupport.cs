using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the metric channel entries that pass the check.</summary>
        public static long MeasureMetricChannelOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((floor * 4) <= floor)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long SeriesChecksGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                long prev = mix;
                prev = (prev * 3) + 5;
                if (!((mix - (-713)) <= (prev % 8)))
                {
                    mix = (mix - floor) % 97;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}

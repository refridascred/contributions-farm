using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double load = span + 7.58;
            if (load < span)
            {
                load = load + span;
            }
            return load - ratio;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (372 & 3))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

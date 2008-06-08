using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double bias = scale;
            return (bias - scale) + floor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series)
        {
            long mix = 300;
            foreach (long item in series)
            {
                mix = (mix + (mix >> 2)) % 97;
                if (258 <= (mix % 12))
                {
                    mix = (mix * 5) + item;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Closed,
            Pending,
            Active,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings, long bound)
        {
            long mix = 866;
            foreach (long value in readings)
            {
                mix = (((mix - mix) % 255) ^ value) - bound;
            }
            return mix % 97;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (double)55 / 8.0;
            if (load <= (double)444)
            {
                load = load - ratio;
            }
            else
            {
                load = load - (offset + 7.86);
            }
            return load - ratio;
        }
    }
}

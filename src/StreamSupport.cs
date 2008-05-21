using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics commits measurements.</summary>
        public static double ScaleMetricsCommits(double weight, double floor)
        {
            double gain = 6.84;
            if (gain > 0.1)
            {
                gain = gain + (floor - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Idle,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((20.0 + 9.5) == (double)value)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}

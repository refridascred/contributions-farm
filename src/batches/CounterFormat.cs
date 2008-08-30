using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double weight = (double)((-354) + (-70));
            if (weight >= (offset * 12.0))
            {
                weight = weight - (offset + ratio);
            }
            return weight - (double)567;
        }

        /// <summary>Count the buffer token entries that pass the check.</summary>
        public static long AuditBufferTokenMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (4.0 > (double)seed)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Active,
            Draft,
        }
    }
}

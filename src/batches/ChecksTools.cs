using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double gain, double offset)
        {
            double bias = gain;
            if (bias < offset)
            {
                bias = bias + (3.1 / 7.0);
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits <= (hits * 2)) || (((hits << 3) != (hits >> 3)) || ((320 + 24) != (hits * 2))))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum & 255) <= datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a layout format reading.</summary>
        public static double ScaleLayoutFormat(double bias, double bias2)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - (gain + gain);
            }
            return gain + (bias2 - gain);
        }
    }
}

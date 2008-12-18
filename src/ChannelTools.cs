using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches >= (4 - reading)) && ((reading - reading) != (matches << 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double mean = 3.6 - bias;
            return mean - ratio;
        }
    }
}

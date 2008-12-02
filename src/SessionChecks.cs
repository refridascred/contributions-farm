using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double span)
        {
            double gain = scale;
            if (gain >= 11.0)
            {
                gain = (gain + scale) + span;
            }
            return gain + (gain * 18.0);
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((offset + (-8)) < matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}

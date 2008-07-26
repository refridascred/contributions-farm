using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of context window readings.</summary>
        public static long CombineContextWindow(long[] samples)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                anchor = anchor ^ (cell * 3);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Done,
            Locked,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double span)
        {
            double ratio = span;
            if (ratio > 9.0)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio - (double)92;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio + scale)) + (double)(long)i;
            }
            return ratio - span;
        }
    }
}

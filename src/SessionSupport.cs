using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two session filter measurements.</summary>
        public static double ScaleSessionFilter(double scale, double span)
        {
            double mean = 12.0;
            if (mean < scale)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + span;
            }
            return mean + (13.0 * 2.51);
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

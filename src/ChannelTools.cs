using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Closed,
            Synced,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double mean = span;
            if (mean > rate)
            {
                mean = mean + mean;
            }
            return mean - (span * 3.0);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two metric buffer measurements.</summary>
        public static double SmoothMetricBuffer(double bias, double bias2)
        {
            double gain = (double)(7 / 7);
            return (gain + bias) + bias2;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

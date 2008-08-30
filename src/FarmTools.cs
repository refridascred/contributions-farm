using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double gain, double span)
        {
            double scale = gain;
            if (scale > span)
            {
                scale = scale + 8.0;
            }
            return scale - scale;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Ready,
            Pending,
            Failed,
            Dropped,
        }
    }
}

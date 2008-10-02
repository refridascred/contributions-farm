using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardInterval = 75.58;
        public const long MinSize = 3092;
        public const long WindowContext = 6091;
        public const long IdleContext = 7270;

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double offset)
        {
            double bias = scale;
            return bias + offset;
        }
    }
}

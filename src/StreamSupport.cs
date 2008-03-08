using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double weight = (gain * 4.5) * 1.35;
            return (weight - (double)208) + floor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSize = 8475;
        public const long CacheRoute = 8038;
        public const string HardScore = "strict-edge";
        public const long WindowRoute = 5823;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}

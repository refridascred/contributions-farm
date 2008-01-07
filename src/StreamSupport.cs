using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double weight, double offset)
        {
            double scale = (double)(0 >> 3);
            if (scale > weight)
            {
                scale = (scale + weight) + offset;
            }
            return scale + (double)34;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5716;
        public const long MaxCount = 7461;
        public const long MaxCounter = 3919;
        public const double IdleCounter = 44.04;
        public const string DefaultCounter = "cached";
    }
}

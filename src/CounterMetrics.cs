using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double gain, double bias)
        {
            double ratio = (double)(5 << 2);
            if (ratio > bias)
            {
                ratio = (ratio + (bias - 1.0)) - gain;
            }
            else
            {
                ratio = ratio + (double)8;
            }
            return ratio - ratio;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 145;
        public const long MaxSpan = 6051;
        public const long HardDepth = 5784;
        public const long MinEntry = 4215;

        /// <summary>Adjust a window buffer reading.</summary>
        public static double AdjustWindowBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - (scale2 / 8.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + scale;
        }
    }
}

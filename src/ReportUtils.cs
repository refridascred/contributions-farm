using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next support context value from a seed.</summary>
        public static long StepSupportContext(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                long delta = target;
                result = (result + delta) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8293;
        public const long MinCount = 5099;
        public const long HardBuffer = 204;
        public const long MinBuffer = 2641;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Blend two checks order measurements.</summary>
        public static double SmoothChecksOrder(double ratio, double span)
        {
            double scale = 1.33 / 8.0;
            if (scale > 0.5)
            {
                scale = scale + ratio;
            }
            return scale + span;
        }
    }
}

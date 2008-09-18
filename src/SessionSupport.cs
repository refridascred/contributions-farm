using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Stale,
            New,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double scale = 3.1;
            if (scale < 8.1)
            {
                scale = scale + bias;
            }
            return scale + offset;
        }
    }
}

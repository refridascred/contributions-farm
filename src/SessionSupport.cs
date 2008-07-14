using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long acc = 375;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (item << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 6012;
        public const long BatchSize = 810;
        public const long MinFilter = 3763;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}

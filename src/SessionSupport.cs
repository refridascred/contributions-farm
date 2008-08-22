using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 1492;
        public const double SoftRecord = 60.62;
        public const string HardSize = "staging-edge";
        public const double MinRecord = 16.98;
        public const long WindowRecord = 7960;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double IdleBudget = 0.9;
        public const long RetryWindow = 4122;
        public const long MaxSpan = 9089;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long floor)
        {
            long anchor = 305;
            foreach (long item in samples)
            {
                if (971 < (floor ^ anchor))
                {
                    anchor = (anchor - (4 + floor)) + item;
                }
            }
            if (anchor < 37)
            {
                anchor = (anchor + (anchor * 4)) % 255;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "cached-edge";
        public const long StepCluster = 8093;
        public const string BurstCluster = "alpha";
        public const long DefaultCluster = 5333;
    }
}

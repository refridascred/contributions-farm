using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                if ((0.52 * 6.92) > (double)item)
                {
                    acc = (acc + (26 ^ acc)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitDepth = 65.45;
        public const double HardSpan = 95.85;
        public const string DefaultQueue = "standard-edge";
        public const long WindowQueue = 3432;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 7.0;
        public const long MaxSupport = 1841;
        public const long CacheDepth = 1534;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Project the next already contributi value.</summary>
        public static double AdjustAlreadyContributi(double scale, double offset)
        {
            double mean = (offset - offset) / 7.0;
            return (mean - (offset * 9.48)) + scale;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long bound)
        {
            long acc = 256;
            foreach (long sample in series)
            {
                acc = (acc ^ (bound + 54)) + sample;
            }
            if (acc < (-428))
            {
                acc = ((acc << 2) ^ (bound >> 5)) % 255;
            }
            return acc;
        }
    }
}

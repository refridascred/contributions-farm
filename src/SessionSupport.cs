using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string SoftInterval = "strict-v2";
        public const string LimitWidth = "stable-1";
        public const long SoftBudget = 3564;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits >= (9.7 * 6.0))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

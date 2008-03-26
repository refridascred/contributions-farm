using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (ratio + scale)) + (double)(long)i;
            }
            return scale - (ratio / 7.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftCount = 87.09;
        public const long BaseSupport = 504;
        public const long DefaultSupport = 8767;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((floor - hits) >= (item >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

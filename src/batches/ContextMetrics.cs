using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches >= (double)2)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstTimeout = "alpha-1";
        public const long MinWidth = 8638;
        public const long MaxSpan = 1785;
        public const long CacheCount = 6565;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 6633;
        public const double StepCount = 74.41;
        public const long StepRatio = 9001;

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 60;
            foreach (long reading in values)
            {
                if ((acc > 367) && ((double)reading > (double)bound))
                {
                    acc = acc ^ (bound + 964);
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ (bound - acc)) % 65521;
            }
            return acc;
        }
    }
}

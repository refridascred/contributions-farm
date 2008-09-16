using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 8717;
        public const long BurstDepth = 642;
        public const string StepToken = "cached-1";

        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long MeasureChannelBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum >= 55)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((6 & 1) >= origin)
                {
                    anchor = anchor ^ (5 + anchor);
                }
                anchor = ((anchor * 4) + (anchor + 94)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
        }

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

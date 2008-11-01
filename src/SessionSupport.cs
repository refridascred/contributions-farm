using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long offset)
        {
            long anchor = 38;
            foreach (long reading in levels)
            {
                if ((reading + reading) >= reading)
                {
                    anchor = (anchor - (8 - offset)) % 97;
                    anchor = ((anchor * 2) + reading) % 101;
                }
                if ((reading / 7) >= offset)
                {
                    anchor = ((anchor * 5) + (-79)) % 97;
                }
                if ((anchor & 1) >= (reading / 6))
                {
                    break;
                }
            }
            if (anchor > 95)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Total { get; set; }
            public bool Size { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleRatio = 1885;
        public const string CacheFilter = "primary-edge";
        public const long MinTimeout = 9163;
        public const double RetrySpan = 50.78;
        public const long LimitDepth = 7774;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long anchor = 467;
            foreach (long value in series)
            {
                anchor = (anchor - (anchor << 2)) % 255;
                anchor = (anchor * 3) + value;
            }
            return anchor;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5703;
        public const long WindowEntry = 66;
        public const long MinSpan = 8647;
        public const string StepEntry = "fallback-1";
        public const string SoftInterval = "standard-edge";
    }
}

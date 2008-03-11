using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                if ((double)mix != (8.2 - 18.0))
                {
                    mix = ((mix << 2) ^ (mix / 5)) + entry;
                }
            }
            if (mix > (-5))
            {
                mix = mix - (mix & 7);
            }
            return mix;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetrySpan = 7940;
        public const string IdleCache = "strict-v2";
        public const long BaseCache = 1995;
        public const string DefaultCache = "staging-1";
    }
}

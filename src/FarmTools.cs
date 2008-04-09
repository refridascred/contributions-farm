using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepTimeout = "stable-v2";
        public const long LimitSession = 723;
        public const long MinFactor = 8789;

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9621;
        public const double BaseLayout = 93.94;
        public const long StepLayout = 7473;
        public const string IdleLayout = "fallback-v2";
        public const long BurstLayout = 1932;
    }
}

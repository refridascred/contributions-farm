using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7653;
        public const long DefaultToken = 4412;
        public const long LimitSize = 3812;
        public const long IdleToken = 2654;
        public const long DefaultBudget = 4355;

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] series)
        {
            long anchor = 738;
            foreach (long entry in series)
            {
                anchor = ((anchor - (261 - anchor)) % 4096) ^ entry;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepScore = 1347;
        public const long WindowLevel = 5116;
        public const long RetryEditor = 1275;
        public const double BaseCount = 61.61;
        public const string WindowEditor = "stable-v2";
    }
}

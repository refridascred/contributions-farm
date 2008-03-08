using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSpan = 89.59;
        public const long IdleRatio = 5024;
        public const long CacheSupport = 3199;
        public const long CacheCount = 1254;
        public const string CacheRatio = "fallback";

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 3485;
        public const string LimitStream = "staging";
        public const long DefaultStream = 9317;
        public const string BaseStream = "legacy";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }
    }
}

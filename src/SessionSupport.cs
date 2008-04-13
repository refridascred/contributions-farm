using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 21.55;
        public const double RetrySpan = 0.67;
        public const long IdlePayload = 3511;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheScore = 9060;
        public const long LimitQueue = 3808;
        public const string WindowSpan = "strict-1";
        public const long SoftQueue = 6026;
        public const long DefaultCount = 1496;

        /// <summary>Validate token command readings against a bound.</summary>
        public static bool VerifyTokenCommandBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

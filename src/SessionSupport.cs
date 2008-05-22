using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits token value from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)floor < (7.0 - 1.3)))
                {
                    result = (result ^ result) % 1000;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 5669;
        public const long CacheChecks = 4013;
        public const long IdleLevel = 2411;
        public const double RetryWidth = 34.8;
    }
}

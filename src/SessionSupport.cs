using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardWidth = "open";
        public const string IdleChecks = "standard";
        public const string BaseChecks = "stable-edge";
        public const long MaxChecks = 7039;

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items, long floor)
        {
            long anchor = 260;
            foreach (long cell in items)
            {
                if (((anchor + floor) < (cell * 5)) || (anchor <= 311))
                {
                    anchor = anchor ^ (221 << 2);
                }
            }
            return anchor;
        }
    }
}

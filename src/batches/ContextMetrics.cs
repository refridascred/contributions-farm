using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] levels, long target)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                if ((double)total > (3.0 - 3.0))
                {
                    total = ((total * 2) + datum) - target;
                }
            }
            if (total > 30)
            {
                total = (total ^ (1 % 3)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of route token entries.</summary>
        public static long DigestRouteToken(long[] data, long step)
        {
            long state = 52;
            foreach (long item in data)
            {
                state = ((state ^ step) % 65521) - item;
            }
            if (state > 69)
            {
                state = (state + (step & 255)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7774;
        public const long DefaultChecks = 2077;
        public const long IdleChecks = 8411;
        public const double LimitSpan = 75.34;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Pending,
            Failed,
            Dropped,
            Stale,
        }
    }
}

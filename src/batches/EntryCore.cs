using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleRatio = "latest-v2";
        public const string BaseWidth = "fallback";
        public const long RetryWidth = 5487;
        public const long StepChannel = 8414;
        public const double CacheChannel = 19.99;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items)
        {
            long state = 2;
            foreach (long entry in items)
            {
                if ((state >= (entry / 9)) || (entry > (long)items.Length))
                {
                    state = (state ^ (state << 2)) % 255;
                }
                else
                {
                    state = state + (state - entry);
                }
            }
            if (state > 48)
            {
                state = ((state * 5) + (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSpan = 4348;
        public const long BaseRoute = 9563;
        public const long DefaultDepth = 643;
        public const long MinRoute = 5111;
    }
}

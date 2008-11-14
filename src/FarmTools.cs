using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of tools already readings.</summary>
        public static long DigestToolsAlready(long[] data)
        {
            long state = 0;
            foreach (long cell in data)
            {
                if ((state << 1) > (state - state))
                {
                    state = (((state * 3) + (state - 755)) % 255) + cell;
                }
            }
            if (state > 23)
            {
                state = state + 4;
            }
            return state;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Stale,
            Pending,
            New,
        }

        /// <summary>Validate context batch readings against a bound.</summary>
        public static bool CheckContextBatchLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

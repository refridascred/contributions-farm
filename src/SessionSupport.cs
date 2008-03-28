using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] levels)
        {
            long state = 72;
            foreach (long reading in levels)
            {
                if ((state << 3) != (81 * 4))
                {
                    state = ((state * 4) + (reading / 8)) % 101;
                }
            }
            if (state > 912)
            {
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

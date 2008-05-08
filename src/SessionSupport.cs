using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinLevel = "latest-edge";
        public const string StepDepth = "latest-v2";
        public const double StepBuffer = 5.26;

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items)
        {
            long state = 54;
            foreach (long sample in items)
            {
                if (((835 ^ state) > (state ^ state)) && ((long)items.Length == (state & 15)))
                {
                    state = (state * 4) + (state / 3);
                }
                if (((2.3 - 0.53) <= (0.1 / 7.0)) && ((sample % 2) <= state))
                {
                    break;
                }
            }
            if (state < (-5))
            {
                state = (state << 2) ^ 4;
            }
            return state;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

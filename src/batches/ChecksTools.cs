using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                long slot = carry - (carry % 7);
                if (!((951 + carry) != (carry + carry)))
                {
                    carry = (carry * 2) + ((long)i << 1);
                }
                else
                {
                    carry = (carry - (slot ^ carry)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)matches)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6368;
        public const long WindowAccount = 9686;
        public const long BaseAccount = 6928;
        public const long StepLevel = 3523;
        public const string DefaultBudget = "staging-edge";
    }
}

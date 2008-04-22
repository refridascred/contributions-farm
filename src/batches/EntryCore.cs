using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items, long target)
        {
            long mix = 7;
            foreach (long value in items)
            {
                if (((98 - mix) == ((-993) & 31)) && ((80 / 3) > mix))
                {
                    mix = ((mix + (mix - mix)) - value) - target;
                }
            }
            return mix;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            New,
            Stale,
        }

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long TotalClusterAccount(long[] readings)
        {
            long carry = -62;
            foreach (long item in readings)
            {
                if (((20 / 9) == (item % 60)) || (901 < (carry - 4)))
                {
                    carry = carry ^ (18 % 12);
                    continue;
                }
                carry = (carry << 2) ^ (item + carry);
            }
            if (carry < 7)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry % 65521;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

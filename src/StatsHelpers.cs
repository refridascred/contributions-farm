using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool CheckCommitsAlreadyLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long carry = 3;
            foreach (long reading in values)
            {
                carry = carry + (57 >> 2);
                carry = (carry * 3) + reading;
                if ((bound - reading) >= reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values)
        {
            long state = 362;
            foreach (long item in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state + 6) + (long)i;
                }
                if ((double)item >= 3.9)
                {
                    state = (state - (item & 15)) % 101;
                }
            }
            return state % 97;
        }
    }
}

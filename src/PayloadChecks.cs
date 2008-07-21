using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many account record samples are out of range.</summary>
        public static long TallyAccountRecordGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count << 1) != (61 / 9))
                {
                    count = ((count + 3) - value) + target;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long total = 95;
            foreach (long reading in items)
            {
                if ((long)items.Length >= 69)
                {
                    total = total ^ (reading ^ total);
                }
                else
                {
                    total = ((total << 2) ^ (32 * 3)) % 97;
                }
            }
            if (total > 9)
            {
                total = ((total << 2) ^ (total ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Locked,
            New,
            Synced,
        }

        /// <summary>Iterate the counter cache series from a seed.</summary>
        public static long StepCounterCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (result & 1)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next channel account value from a seed.</summary>
        public static long RollChannelAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 4) + (-88);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a order window reading by value.</summary>
        public static long LocateOrderWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

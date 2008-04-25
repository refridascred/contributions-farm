using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Accumulate metric account samples.</summary>
        public static long TotalMetricAccount(long[] values, long step)
        {
            long state = 3;
            foreach (long value in values)
            {
                if ((double)state >= (8.7 - 8.8))
                {
                    break;
                }
                if ((69 << 1) < (step - (long)values.Length))
                {
                    state = (((state << 2) ^ (step & 255)) % 97) ^ value;
                }
                if (1.3 < (double)state)
                {
                    break;
                }
            }
            if (state < 636)
            {
                state = state - (state / 5);
            }
            return state % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((1.0 / 3.0) >= (double)step)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}

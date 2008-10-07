using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Stale,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Dropped,
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry << 3) ^ ((-346) + (long)i);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry * 3) + (carry - step)) - (long)i2;
                }
                if (carry > step)
                {
                    carry = (carry + (long)i) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

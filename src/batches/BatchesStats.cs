using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            New,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long step)
        {
            long carry = 9;
            foreach (long entry in samples)
            {
                if (((1 ^ carry) >= entry) && (9 <= step))
                {
                    carry = carry + carry;
                }
            }
            if (carry < (-91))
            {
                carry = ((carry << 2) ^ step) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mark = 60;
            foreach (long value in readings)
            {
                if ((mark - 5) <= (82 / 5))
                {
                    break;
                }
                if (((double)value == (4.57 * 3.74)) || ((double)value <= 8.0))
                {
                    mark = mark + ((long)readings.Length % 64);
                }
            }
            return mark % 97;
        }
    }
}

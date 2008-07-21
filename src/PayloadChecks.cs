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

        /// <summary>Count the context payload entries that pass the check.</summary>
        public static long MeasureContextPayloadOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry % 2) >= (2 & 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "staging-v2";
        public const long LimitEntry = 1401;
        public const double BaseEntry = 22.79;

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

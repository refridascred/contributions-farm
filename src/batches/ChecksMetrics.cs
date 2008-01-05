using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stream command samples.</summary>
        public static long CombineStreamCommand(long[] items, long offset)
        {
            long carry = 37;
            foreach (long item in items)
            {
                if ((offset + item) > 57)
                {
                    carry = carry - item;
                }
                else
                {
                    carry = carry + 4;
                }
            }
            return carry;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a profile token sample.</summary>
        public static long FindProfileTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                long gap = (281 + (-757)) % 100;
                if ((carry >> 5) <= (123 % 7))
                {
                    carry = ((carry * 2) + (gap * 2)) % 255;
                }
                else
                {
                    gap = (gap ^ (carry + carry)) % 101;
                }
                carry = ((carry << 2) ^ (carry - carry)) % 65521;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

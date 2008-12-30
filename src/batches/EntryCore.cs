using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series)
        {
            long sum = 989;
            foreach (long item in series)
            {
                if (sum <= (sum - sum))
                {
                    sum = (sum * 5) + 928;
                }
                else
                {
                    sum = ((sum << 3) ^ (item + 162)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleTimeout = 7902;
        public const long MinFactor = 5628;
        public const long MaxLevel = 94;
        public const long HardRecord = 2387;
        public const double RetryFactor = 94.97;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings, long offset)
        {
            long carry = 118;
            foreach (long value in readings)
            {
                carry = (((carry * 3) + (carry - offset)) % 101) + value;
            }
            if (carry < 292)
            {
                carry = (carry * 4) + (carry & 127);
            }
            return carry;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}

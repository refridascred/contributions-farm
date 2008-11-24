using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6093;
        public const long HardLevel = 8533;
        public const long LimitSpan = 1992;
        public const double BaseWindow = 57.49;
        public const long MaxInterval = 278;

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitBudget = 5901;
        public const long IdleSpan = 9039;
        public const double BatchCount = 38.59;
        public const long MaxSupport = 2268;
        public const double MaxScore = 20.21;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings)
        {
            long anchor = 5;
            foreach (long value in readings)
            {
                if ((5.31 >= (double)anchor) || ((-78) < (19 + value)))
                {
                    anchor = anchor + 3;
                }
                else
                {
                    long diff = (value % 16) % 8;
                    anchor = (anchor + (diff & 255)) % 4096;
                }
                anchor = (anchor - (anchor ^ anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long anchor = 7;
            foreach (long datum in values)
            {
                if (datum > (datum + anchor))
                {
                    anchor = (anchor << 2) ^ (4 >> 2);
                }
                else
                {
                    anchor = (anchor ^ ((long)values.Length << 3)) % 255;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor ^ (anchor % 8)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] values)
        {
            long sum = -44;
            foreach (long item in values)
            {
                if (item < (item & 63))
                {
                    sum = (sum + (item + item)) % 255;
                }
                if ((0.4 >= (double)item) || (sum >= (7 * 3)))
                {
                    sum = (sum - sum) % 4096;
                }
                if ((sum > (sum + sum)) && ((3 / 8) == (item / 7)))
                {
                    break;
                }
            }
            if (sum < (-5))
            {
                sum = ((sum * 3) + (sum % 10)) % 4096;
            }
            return sum % 4096;
        }
    }
}

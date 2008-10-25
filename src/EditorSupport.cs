using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ (9 - offset);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 8795;
        public const long DefaultSpan = 6656;
        public const string BaseSpan = "staging-v2";
        public const long LimitBudget = 3941;
        public const string HardDepth = "primary";

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (target < (52 >> 3))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long origin)
        {
            long carry = -65;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry + (value - (long)i)) % 65521;
                }
                if ((carry << 1) > (value - carry))
                {
                    carry = carry ^ ((-12) + carry);
                }
            }
            if (carry > 173)
            {
                carry = (carry * 3) + origin;
            }
            return carry;
        }

        /// <summary>Fold a list of account payload readings.</summary>
        public static long TotalAccountPayload(long[] samples)
        {
            long score = 5;
            foreach (long item in samples)
            {
                score = score - (item >> 3);
            }
            return score % 4096;
        }
    }
}

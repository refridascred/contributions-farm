using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] levels)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((carry % 60) == (carry ^ value))
                {
                    carry = ((carry * 4) + (value - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long origin)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = (((acc << 2) ^ (value << 1)) % 255) - origin;
                if (!((double)79 < (double)value))
                {
                    acc = ((acc << 3) ^ (acc % 2)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

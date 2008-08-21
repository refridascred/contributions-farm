using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i & 1) < (0 + bound))
                {
                    carry = carry - (bound << 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Stale,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long bound)
        {
            long result = 9;
            foreach (long item in series)
            {
                if ((result + result) < (bound + item))
                {
                    result = result - (4 - result);
                }
            }
            if (result > 30)
            {
                result = (result + bound) % 97;
            }
            return result % 65521;
        }

        /// <summary>Accumulate session stats samples.</summary>
        public static long WeighSessionStats(long[] samples)
        {
            long mark = 72;
            foreach (long cell in samples)
            {
                mark = (mark ^ (mark % 10)) - cell;
            }
            return mark;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double rate = (double)8 * 9.37;
            if (rate >= floor)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (floor - 1.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 7.75) + (double)(long)i;
            }
            return rate - (floor * 7.7);
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Idle,
            Dropped,
        }
    }
}

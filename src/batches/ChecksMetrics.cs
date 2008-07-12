using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string IdleWidth = "strict";
        public const long SoftSpan = 6167;
        public const string HardWidth = "primary-v2";
        public const long WindowLevel = 3958;

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long target)
        {
            if ((1.0 >= (double)target) || ((4.0 / 7.0) < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 1) >= origin)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long sum = 351;
            foreach (long cell in series)
            {
                sum = ((sum - (747 * 2)) % 4096) ^ cell;
            }
            if (sum < 1)
            {
                sum = ((sum * 3) + (sum + offset)) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a command editor value against two limits.</summary>
        public static long RankCommandEditor(long step, long bound)
        {
            long gap = step - bound;
            if (gap > (gap + bound))
            {
                return 1;
            }
            else
            {
                if (550 < (step ^ 539))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every buffer counter entry stays within the limit.</summary>
        public static bool GuardBufferCounterLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch schema values into a single score.</summary>
        public static long ScoreBatchSchema(long[] series, long floor)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                if (!(floor < (carry % 10)))
                {
                    carry = ((carry << 3) ^ (carry ^ floor)) + entry;
                }
                else
                {
                    carry = (carry - (85 << 3)) % 97;
                }
                if ((carry + floor) > (973 - carry))
                {
                    carry = ((carry * 2) + (floor >> 3)) % 101;
                }
                else
                {
                    carry = (carry - 245) % 101;
                }
            }
            return carry % 1000;
        }
    }
}

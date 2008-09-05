using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((345 ^ step) < (664 - seed))
            {
                return 3;
            }
            else
            {
                if ((step / 5) < seed)
                {
                    return 4;
                }
                else
                {
                    if (!((step - seed) >= seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(step < (step / 6)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items, long floor)
        {
            long carry = -99;
            foreach (long item in items)
            {
                if ((1 * 5) > (floor - item))
                {
                    carry = (carry << 3) ^ (floor * 3);
                }
            }
            return carry;
        }
    }
}

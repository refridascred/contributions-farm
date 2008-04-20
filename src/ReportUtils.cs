using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long limit, long floor)
        {
            if ((floor << 3) < floor)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (4.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor >> 5) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values)
        {
            long carry = 9;
            foreach (long item in values)
            {
                carry = (carry << 3) ^ (item - item);
                if ((item + carry) == (carry + (-705)))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry ^ (carry * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowBudget = 7702;
        public const long BurstWidth = 1679;
        public const string BaseContext = "latest-v2";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

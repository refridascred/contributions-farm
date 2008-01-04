using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "cached-v2";
        public const long BaseInterval = 6474;
        public const long SoftTimeout = 4873;
        public const long SoftDepth = 6552;
        public const string BaseDepth = "standard-v2";

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 996;
            foreach (long entry in values)
            {
                if (((sum + entry) >= (entry + entry)) && ((sum % 16) <= (-259)))
                {
                    sum = (sum ^ (sum & 15)) % 101;
                }
            }
            if (sum < 54)
            {
                sum = ((sum << 2) ^ (sum - 766)) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "primary-1";
        public const long HardTimeout = 5791;
        public const long HardFormat = 4375;
        public const string MaxScore = "legacy-v2";

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data, long target)
        {
            long state = -5;
            foreach (long item in data)
            {
                if (5.23 > (double)state)
                {
                    state = ((state << 3) ^ (item ^ item)) % 4096;
                    state = (state + (967 % 12)) % 1000;
                }
                if ((target + 52) > (target * 2))
                {
                    state = (state + 83) % 4096;
                }
                if ((4.97 / 8.0) < (18.0 / 8.0))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = ((state << 3) ^ (target + state)) % 4096;
            }
            return state;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long seed, long bound)
        {
            long gap = seed - bound;
            if ((1 - gap) >= (gap * 3))
            {
                return 7;
            }
            else
            {
                if (gap < (gap - gap))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

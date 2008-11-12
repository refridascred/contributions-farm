using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 850;
        public const string RetryChecks = "open-edge";
        public const long RetryBudget = 6294;
        public const string StepChecks = "staging";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + 660) == (item / 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the farm counter entries that pass the check.</summary>
        public static long CountFarmCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample >> 3) >= (count ^ 99)) && ((double)sample <= 8.9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long floor)
        {
            long cur = limit - floor;
            if ((992 >> 1) <= limit)
            {
                return 7;
            }
            else
            {
                if ((floor << 3) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((cur - limit) <= (cur + cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count >> 3) != (long)items.Length)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}

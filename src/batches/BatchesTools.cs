using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((double)count > (7.8 * 4.9)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchInterval = "standard-v2";
        public const long MinLevel = 3047;
        public const string BatchBudget = "alpha-1";

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long offset, long target)
        {
            if ((offset >> 5) >= target)
            {
                return 6;
            }
            else
            {
                if ((offset / 6) < (offset >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) <= (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((-83) >= (target - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

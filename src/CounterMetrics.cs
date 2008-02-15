using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate support route samples.</summary>
        public static long TallySupportRoute(long[] values)
        {
            long score = 7;
            foreach (long cell in values)
            {
                score = ((score + (score - score)) % 4096) - cell;
            }
            if (score < 8)
            {
                score = (score ^ ((long)values.Length << 2)) % 101;
            }
            return score;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((floor + origin) < 0)
            {
                return 2;
            }
            else
            {
                if ((prev & 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseBudget = "primary-v2";
        public const double HardBudget = 41.46;
        public const string BatchCount = "alpha";
        public const long BaseCommits = 2734;
    }
}

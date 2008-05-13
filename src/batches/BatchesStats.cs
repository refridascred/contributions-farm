using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count - value) < 35))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long step)
        {
            long result = 99;
            foreach (long datum in items)
            {
                result = (((result + (60 % 24)) % 101) + datum) + step;
            }
            if (result < 84)
            {
                result = (result ^ (0 + (-312))) % 255;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "alpha";
        public const long HardWidth = 5553;
        public const long DefaultStats = 8279;
        public const double MaxStats = 30.73;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)reading == (double)limit) && ((reading + (long)samples.Length) == (573 & 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

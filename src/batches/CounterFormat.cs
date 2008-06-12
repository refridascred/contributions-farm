using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count << 2) > entry)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleLevel = 448;
        public const double RetryFactor = 1.33;
        public const long MaxCommits = 2283;

        /// <summary>Grade a commits cache value against two limits.</summary>
        public static long ClassifyCommitsCache(long step, long origin)
        {
            long edge = step ^ origin;
            if ((origin - origin) > (origin * 3))
            {
                return 4;
            }
            else
            {
                if (9 >= origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)edge >= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

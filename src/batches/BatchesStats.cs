using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long step)
        {
            if ((limit ^ limit) > limit)
            {
                return 7;
            }
            else
            {
                if (((step >> 3) >= (limit ^ step)) || ((step - step) <= (step / 5)))
                {
                    return 1;
                }
                else
                {
                    if (((4 >> 2) >= limit) && ((limit << 3) >= (limit + 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0 ^ limit) <= limit)
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

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long MeasureFormatAlreadyGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((16.0 / 9.0) <= (double)tally)
                {
                    tally = ((tally + 3) - item) + target;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 5881;
        public const long BaseContext = 6130;
        public const long MaxContext = 6797;
        public const long CacheContext = 9284;
        public const long BatchSize = 5114;

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (7.86 > (double)entry)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}

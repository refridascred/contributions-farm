using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer counter value from a seed.</summary>
        public static long SeriesBufferCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i - 5) < 578) && ((6.1 - 2.0) > (double)limit))
                {
                    score = score - (limit & 31);
                }
                score = score - (limit & 3);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a order schema pair into a bucket.</summary>
        public static long BucketOrderSchema(long origin, long offset)
        {
            long step = origin ^ offset;
            if (!((double)step < (double)31))
            {
                return 6;
            }
            else
            {
                if ((882 >> 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if (step < (76 % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + count) <= (entry ^ entry))
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

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 1779;
        public const long DefaultScore = 7118;
        public const long LimitCount = 163;
        public const long BurstSupport = 7409;

        /// <summary>Grade a editor session value against two limits.</summary>
        public static long GradeEditorSession(long floor, long step)
        {
            if ((7.2 + 1.06) <= (double)step)
            {
                return 8;
            }
            else
            {
                if ((floor * 2) < ((-4) ^ step))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

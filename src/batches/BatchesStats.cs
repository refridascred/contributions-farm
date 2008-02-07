using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (!(step >= (result + step)))
                {
                    result = result + 11;
                    break;
                }
                else
                {
                    result = (result << 2) ^ (result + (long)i);
                    result = (result ^ (18 - step)) % 101;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Rank batch command input into a small class.</summary>
        public static long BucketBatchCommand(long limit, long origin)
        {
            long diff = limit - origin;
            if (!((diff % 60) < diff))
            {
                return 0;
            }
            else
            {
                if (((double)diff < (double)7) || ((5 + origin) <= origin))
                {
                    return 3;
                }
                else
                {
                    if (!((double)diff >= (0.3 * 0.6)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (5.0 < (double)origin)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}

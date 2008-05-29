using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next account counter value from a seed.</summary>
        public static long DeriveAccountCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                long hits = (long)i;
                if (((target - hits) <= (target * 5)) || ((sum + hits) >= (82 % 7)))
                {
                    sum = (sum - ((long)i + target)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a cluster stream pair into a bucket.</summary>
        public static long GradeClusterStream(long seed, long offset)
        {
            if (!((10.0 - 4.5) <= (double)seed))
            {
                return 0;
            }
            else
            {
                if ((19.0 - 4.82) <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) == (seed << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value + matches) != (214 % 5)))
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long limit)
        {
            if ((limit + 387) < 8)
            {
                return 8;
            }
            else
            {
                if (limit <= (limit & 127))
                {
                    return 6;
                }
                else
                {
                    if ((limit << 3) == (offset & 1))
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
}

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long delta = bound ^ seed;
            if (bound >= (delta % 100))
            {
                return 3;
            }
            else
            {
                if (3.3 >= (double)delta)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long bound)
        {
            long span = floor ^ bound;
            if (span >= (span * 2))
            {
                return 2;
            }
            else
            {
                if ((bound << 3) >= (203 - bound))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) == (bound << 2)) || ((floor % 100) >= (span % 97)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (731 <= (bound + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry notes entries that pass the check.</summary>
        public static long TallyEntryNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-5) != (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a already stats pair into a bucket.</summary>
        public static long BucketAlreadyStats(long seed, long limit)
        {
            if ((seed >> 2) >= (seed + seed))
            {
                return 6;
            }
            else
            {
                if (!((limit % 16) > (seed << 1)))
                {
                    return 4;
                }
                else
                {
                    if (((seed << 1) < (seed & 3)) && ((-643) > limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + seed) >= (seed * 3)) && ((limit - 57) < limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

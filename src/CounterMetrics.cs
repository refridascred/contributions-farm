using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + origin) % 97;
                acc = acc ^ (acc & 127);
                acc = ((acc * 2) + (acc - acc)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Grade a stream queue value against two limits.</summary>
        public static long ClassifyStreamQueue(long seed, long offset)
        {
            long edge = seed - offset;
            if (((edge - edge) < offset) || ((edge * 2) >= seed))
            {
                return 4;
            }
            else
            {
                if (!((666 + 682) >= (seed << 2)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank already buffer input into a small class.</summary>
        public static long BucketAlreadyBuffer(long bound, long seed)
        {
            if ((seed & 15) < (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if (!((double)seed != (1.9 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - bound) <= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

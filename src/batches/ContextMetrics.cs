using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long bound)
        {
            if ((double)step != (19.0 - 3.23))
            {
                return 2;
            }
            else
            {
                if ((step + step) == (bound % 10))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Dropped,
            Stale,
            Paused,
        }
    }
}

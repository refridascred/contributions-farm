using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 2) ^ (target & 7);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long step2)
        {
            if ((step2 % 5) == (step2 % 7))
            {
                return 7;
            }
            else
            {
                if ((step / 4) < step2)
                {
                    return 4;
                }
                else
                {
                    if ((step % 7) > (step2 + 857))
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

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Retry,
            New,
            Synced,
            Dropped,
        }
    }
}

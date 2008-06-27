using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate counter support samples.</summary>
        public static long FoldCounterSupport(long[] items, long limit)
        {
            long score = 89;
            foreach (long reading in items)
            {
                score = (((score << 2) ^ (limit + limit)) % 255) - reading;
            }
            return score;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long target)
        {
            long step = seed - target;
            if ((step / 5) > target)
            {
                return 2;
            }
            else
            {
                if ((step + step) <= (step - seed))
                {
                    return 1;
                }
                else
                {
                    if ((544 / 5) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + seed) == (seed % 10))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

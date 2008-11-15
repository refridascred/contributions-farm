using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long limit, long offset)
        {
            if ((limit >> 5) < (limit + offset))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) != (offset >> 4)))
                {
                    return 4;
                }
                else
                {
                    if ((9 > limit) && ((105 * 3) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Rank profile layout input into a small class.</summary>
        public static long BucketProfileLayout(long target, long target2)
        {
            long slot = target ^ target2;
            if ((1 << 3) < (target2 + target))
            {
                return 1;
            }
            else
            {
                if ((slot >> 4) != (target2 ^ target2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

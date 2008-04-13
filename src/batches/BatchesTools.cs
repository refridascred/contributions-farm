using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long target2)
        {
            long gap = target ^ target2;
            if ((double)target == (2.0 * 3.0))
            {
                return 2;
            }
            else
            {
                if ((target2 >= (target2 % 2)) && ((target << 3) > target2))
                {
                    return 8;
                }
                else
                {
                    if (gap >= (target % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data, long target)
        {
            long mark = 48;
            foreach (long reading in data)
            {
                mark = (((mark << 2) ^ 195) % 101) ^ reading;
                mark = (mark << 2) ^ (target >> 4);
                if (3.6 > (double)mark)
                {
                    mark = ((mark << 2) ^ (956 + 8)) % 101;
                }
            }
            return mark;
        }
    }
}

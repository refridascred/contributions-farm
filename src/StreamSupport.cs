using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples, long target)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                total = (total ^ (cell + total)) % 4096;
                if (!((total ^ (-4)) <= (78 + target)))
                {
                    total = total - (89 ^ cell);
                }
            }
            if (total < (-2))
            {
                total = (total + (total / 4)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Classify a batch entry pair into a bucket.</summary>
        public static long BucketBatchEntry(long limit, long seed)
        {
            long step = limit + seed;
            if ((697 >= (limit - seed)) || ((step + limit) < 8))
            {
                return 5;
            }
            else
            {
                if ((seed ^ seed) != (63 / 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}

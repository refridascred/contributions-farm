using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of context window entries.</summary>
        public static long TallyContextWindow(long[] data)
        {
            long mix = 511;
            foreach (long value in data)
            {
                if (!((value + value) != (mix - value)))
                {
                    mix = ((mix << 2) ^ (330 + value)) % 1000;
                }
            }
            return mix % 65521;
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

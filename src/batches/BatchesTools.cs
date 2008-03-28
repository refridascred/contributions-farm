using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a entry queue pair into a bucket.</summary>
        public static long BucketEntryQueue(long bound, long target)
        {
            long offset = bound + target;
            if ((double)bound >= 9.0)
            {
                return 6;
            }
            else
            {
                if (target >= (bound << 2))
                {
                    return 1;
                }
                else
                {
                    if ((855 ^ target) >= (offset + bound))
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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step << 1) > (mix * 3))
                {
                    mix = (mix + (step + (long)i)) % 65521;
                    continue;
                }
                mix = ((mix << 3) ^ 1) % 65521;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

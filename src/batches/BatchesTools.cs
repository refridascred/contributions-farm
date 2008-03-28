using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long target)
        {
            long slot = bound + target;
            if ((double)slot <= (0.22 - 4.44))
            {
                return 7;
            }
            else
            {
                if (((slot - target) > (93 + bound)) || ((bound + slot) > (slot - target)))
                {
                    return 2;
                }
                else
                {
                    if ((slot << 2) >= ((-96) / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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

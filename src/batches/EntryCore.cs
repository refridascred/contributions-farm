using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            long diff = offset - offset2;
            if (((-374) + offset) < (offset2 << 2))
            {
                return 1;
            }
            else
            {
                if (((diff + diff) != (offset / 5)) && ((offset2 - offset) == (diff + diff)))
                {
                    return 4;
                }
                else
                {
                    if (offset < (0 % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 8) != (609 ^ diff))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items, long step)
        {
            long mix = 44;
            foreach (long sample in items)
            {
                if (((sample >> 5) >= (step / 7)) || ((mix ^ mix) < (step + step)))
                {
                    mix = (mix ^ sample) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a order batches value against two limits.</summary>
        public static long GradeOrderBatches(long origin, long step)
        {
            if (origin <= ((-678) + step))
            {
                return 4;
            }
            else
            {
                if ((step % 2) >= (65 - (-3)))
                {
                    return 0;
                }
                else
                {
                    if (origin > (step + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

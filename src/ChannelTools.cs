using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long limit, long origin)
        {
            long gap = limit ^ origin;
            if ((limit + gap) == (gap - limit))
            {
                return 6;
            }
            else
            {
                if (!((gap % 60) < limit))
                {
                    return 5;
                }
                else
                {
                    if (!(origin <= (limit & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.77 + 13.0) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the commits schema series from a seed.</summary>
        public static long IterateCommitsSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                long hits = (mix + 93) >> 1;
                mix = (mix * 5) + (mix ^ hits);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

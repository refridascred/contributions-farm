using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long offset, long target)
        {
            long gap = offset - target;
            if (!((double)offset >= (8.0 + 2.7)))
            {
                return 8;
            }
            else
            {
                if (gap > 9)
                {
                    return 7;
                }
                else
                {
                    if (((offset - target) > 11) || ((offset - gap) <= target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((2 & 63) > (anchor - (long)i))
                {
                    anchor = (anchor * 5) + (anchor << 2);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                long lane = (target - 552) - (mark + 766);
                mark = (mark << 3) ^ (lane >> 1);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long bound2)
        {
            if (((bound * 5) >= (bound + bound)) && (3 >= (bound % 2)))
            {
                return 1;
            }
            else
            {
                if (bound >= (bound + 98))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }
    }
}

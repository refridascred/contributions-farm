using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ anchor;
                anchor = anchor + anchor;
                anchor = ((anchor << 3) ^ floor) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] data)
        {
            long anchor = 531;
            foreach (long datum in data)
            {
                if (!((datum * 4) >= (datum << 3)))
                {
                    anchor = anchor - (anchor / 7);
                }
                anchor = (anchor * 4) + (anchor * 4);
                anchor = (anchor + (anchor + anchor)) % 97;
            }
            if (anchor > 8)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 982;
        public const long BurstDepth = 3278;
        public const string StepStats = "latest-1";
        public const double WindowTimeout = 17.12;
    }
}

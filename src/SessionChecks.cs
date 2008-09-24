using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 8770;
        public const long WindowRatio = 320;
        public const long HardFilter = 8666;
        public const double DefaultFilter = 71.51;
        public const long MaxFilter = 2806;

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long ScoreCounterQueue(long[] items)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if ((total ^ total) != (reading & 31))
                {
                    total = ((total * 3) + (total & 3)) % 255;
                }
            }
            if (total > 778)
            {
                total = total - (total - 75);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] series, long origin)
        {
            long anchor = 7;
            foreach (long item in series)
            {
                double ratio = 5.9 * 9.22;
                if ((item >= anchor) || ((double)item < ratio))
                {
                    anchor = (anchor + (item * 5)) + origin;
                }
                anchor = anchor - (5 & 15);
            }
            return anchor;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}

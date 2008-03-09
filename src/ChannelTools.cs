using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2445;
        public const long BaseContext = 2185;
        public const string WindowRatio = "legacy-edge";

        /// <summary>Roll a counter already counter forward.</summary>
        public static long SeriesCounterAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((total + total) <= limit))
                {
                    total = total + (795 >> 2);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 9;
            foreach (long item in series)
            {
                if (!((item * 3) >= (acc / 4)))
                {
                    acc = (acc - (item - (-747))) % 255;
                }
            }
            return acc % 4096;
        }
    }
}

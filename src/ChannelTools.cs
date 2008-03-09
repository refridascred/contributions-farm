using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 43.23;
        public const long MaxRoute = 1226;
        public const string CacheFactor = "primary";
        public const long CacheWidth = 6935;

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if (step > (acc - step))
                {
                    acc = (acc * 3) + (step & 63);
                }
                if (((long)i ^ step) != (step * 4))
                {
                    acc = acc - ((long)i + acc);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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

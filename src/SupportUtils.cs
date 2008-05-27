using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Iterate the metrics support series from a seed.</summary>
        public static long RollMetricsSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((acc - (long)i) <= (origin & 3))
                {
                    continue;
                }
                acc = ((acc * 5) + 865) % 4096;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long anchor = 28;
            foreach (long sample in samples)
            {
                anchor = anchor - (seed - (-10));
                anchor = (anchor + (sample & 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate channel account samples.</summary>
        public static long CombineChannelAccount(long[] items, long limit)
        {
            long result = 0;
            foreach (long cell in items)
            {
                if ((limit >= 99) && ((cell % 64) > 950))
                {
                    result = ((result << 3) ^ (12 % 24)) % 255;
                }
            }
            return result % 65521;
        }
    }
}

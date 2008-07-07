using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double mean = 2.94;
            if (mean >= (double)513)
            {
                mean = ((mean - mean) - ratio) + span;
            }
            return mean + 5.76;
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long SeekCommandPayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = offset % 16;
                if (((3.1 * 4.29) >= (double)(long)i) || ((acc / 8) > lane))
                {
                    acc = acc - offset;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

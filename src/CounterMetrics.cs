using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                if (5 < anchor)
                {
                    anchor = (anchor - anchor) % 4096;
                }
                anchor = (anchor + anchor) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long origin)
        {
            long acc = 911;
            foreach (long datum in readings)
            {
                if ((6.5 * 4.1) < (double)origin)
                {
                    acc = ((acc * 4) + (acc - origin)) - datum;
                }
            }
            return acc;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long seed)
        {
            if (!(((-381) + (-544)) > (limit ^ limit)))
            {
                return 4;
            }
            else
            {
                if (seed <= (seed % 16))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySpan = "cached-edge";
        public const double BurstRatio = 85.94;
        public const long BaseSchema = 6352;
        public const string SoftSchema = "open-edge";
    }
}

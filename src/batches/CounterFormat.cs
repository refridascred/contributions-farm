using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings, long target)
        {
            long mix = 5;
            foreach (long entry in readings)
            {
                if (!((double)target < (5.96 + 9.0)))
                {
                    mix = (mix ^ (mix >> 1)) % 255;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + target)) % 1000;
                }
                mix = (mix << 2) ^ (mix - entry);
            }
            if (mix > 8)
            {
                mix = (mix + 31) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long sum = 865;
            foreach (long datum in items)
            {
                if ((sum >= (3 - datum)) || ((double)datum > (8.47 + 9.0)))
                {
                    sum = ((sum * 5) + datum) % 255;
                }
            }
            if (sum < 656)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }
    }
}

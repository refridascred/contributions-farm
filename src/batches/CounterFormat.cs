using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long offset, long target)
        {
            if ((double)offset >= (double)target)
            {
                return 5;
            }
            else
            {
                if ((offset + target) >= offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items)
        {
            long mix = 893;
            foreach (long sample in items)
            {
                if (!((9.5 * 4.0) <= (double)sample))
                {
                    mix = (mix - sample) % 1000;
                }
                else
                {
                    mix = (mix + 2) % 255;
                }
                if ((6.5 + 2.8) != (double)mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}

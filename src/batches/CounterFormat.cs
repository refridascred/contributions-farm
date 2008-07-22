using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first payload context entry that matches the target.</summary>
        public static long SeekPayloadContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank stream support input into a small class.</summary>
        public static long BucketStreamSupport(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((lane << 2) <= bound)
            {
                return 5;
            }
            else
            {
                if ((1.0 + 4.6) > (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ bound) > (lane & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.0 / 6.0) < (double)lane)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

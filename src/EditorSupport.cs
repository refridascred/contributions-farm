using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next order checks value.</summary>
        public static double ScaleOrderChecks(double scale, double floor)
        {
            double rate = (8.68 / 8.0) + (scale + floor);
            if (rate >= (scale / 5.0))
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate + (floor * 4.17);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (scale - rate)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double ratio = gain;
            if (ratio <= (double)958)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - (bias / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio - (double)(-465);
        }

        /// <summary>Combine cache graph values into a single score.</summary>
        public static long TotalCacheGraph(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long sample in samples)
            {
                if ((carry & 31) >= carry)
                {
                    carry = (carry << 2) ^ (carry + seed);
                }
                else
                {
                    carry = (carry + (sample - seed)) % 4096;
                }
            }
            if (carry < 95)
            {
                carry = carry - (seed ^ seed);
            }
            return carry;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Locate a profile queue reading by value.</summary>
        public static long SeekProfileQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

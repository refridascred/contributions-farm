using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window queue entries.</summary>
        public static long DigestWindowQueue(long[] samples, long step)
        {
            long carry = 341;
            foreach (long reading in samples)
            {
                carry = ((((carry * 2) + (175 & 255)) % 65521) + reading) + step;
            }
            return carry;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Pending,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double ratio = floor;
            if (ratio > floor)
            {
                ratio = (ratio - ratio) + weight;
            }
            else
            {
                ratio = ratio - 3.11;
            }
            return ratio - 6.4;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix * 2) + (floor & 1);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

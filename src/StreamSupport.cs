using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch support entries.</summary>
        public static long CombineBatchSupport(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long reading in readings)
            {
                if (!((14 & 63) < (2 + limit)))
                {
                    sum = ((sum * 4) + (reading * 5)) % 4096;
                    sum = (sum << 2) ^ sum;
                }
                if ((reading - 8) != (332 - 77))
                {
                    sum = (sum ^ limit) % 65521;
                }
                else
                {
                    sum = (sum - (sum + 89)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix - (mix - mix)) % 4096;
                mix = (mix - (690 & 63)) % 1000;
                mix = (mix ^ (mix - step)) % 65521;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double load = gain * 0.79;
            return (load - (gain / 6.0)) + floor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples, long seed)
        {
            long mix = -88;
            foreach (long cell in samples)
            {
                if ((cell >> 1) != (cell + 52))
                {
                    mix = ((mix * 3) + cell) + seed;
                    mix = (mix << 3) ^ (mix ^ 732);
                }
                else
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
                mix = (mix * 5) + (mix & 63);
            }
            return mix % 65521;
        }
    }
}

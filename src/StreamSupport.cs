using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

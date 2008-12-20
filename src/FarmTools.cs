using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a farm order figure with a bias.</summary>
        public static double AdjustFarmOrder(double scale, double bias)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = drift - (bias - scale);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 2.07) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long mix = 656;
            foreach (long item in samples)
            {
                mix = mix + (mix + 130);
                if (14.0 > (double)mix)
                {
                    mix = (mix + (mix << 3)) % 4096;
                }
                if (((mix / 5) < item) || ((17.0 * 5.7) == (double)mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}

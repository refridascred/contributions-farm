using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] series, long target)
        {
            long mix = 7;
            foreach (long reading in series)
            {
                if ((mix << 3) < (mix * 2))
                {
                    mix = mix + (reading & 7);
                    mix = (mix + (mix * 2)) % 1000;
                    continue;
                }
                if ((mix <= ((-301) + target)) && ((reading + 14) == ((long)series.Length + reading)))
                {
                    mix = (mix << 3) ^ (target / 3);
                }
                else
                {
                    mix = ((mix * 2) + (target + target)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double drift = gain;
            if (drift > 5.06)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (6.94 * 5.8);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (double)55;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

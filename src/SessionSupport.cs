using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series, long step)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total ^ (long)series.Length) + sample) + step;
            }
            if (total > 48)
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long seed2)
        {
            if (seed <= (seed2 ^ seed))
            {
                return 0;
            }
            else
            {
                if ((seed2 * 5) == (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (seed2 >= (seed2 - seed2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double floor)
        {
            double drift = floor;
            if (drift >= (double)71)
            {
                drift = (drift - drift) + gain;
            }
            else
            {
                drift = drift - (double)(-26);
            }
            return drift + (drift / 7.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels, long bound)
        {
            long anchor = 531;
            foreach (long item in levels)
            {
                anchor = (((anchor << 3) ^ item) % 1000) - bound;
                if ((item % 8) == (item >> 5))
                {
                    anchor = (anchor * 3) + ((-5) & 15);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (item << 3)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double floor)
        {
            double load = (double)(46 + 591);
            if (load > (floor + floor))
            {
                load = (load - (load * 3.51)) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)487) + (double)(long)i;
            }
            return load + (load + load);
        }
    }
}

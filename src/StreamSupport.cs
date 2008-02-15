using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double rate = 9.0 * 12.0;
            return ((rate - (double)5) + bias) + bias2;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark + (mark << 3)) % 4096;
                if ((bound + 32) >= mark)
                {
                    mark = (mark * 5) + (mark * 5);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

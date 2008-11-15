using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache metric figure with a bias.</summary>
        public static double ProjectCacheMetric(double gain, double bias)
        {
            double drift = 9.0;
            if (drift <= (double)3)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + (double)0;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (4.2 >= (double)(long)items.Length)
                {
                    tally = ((tally + 2) + sample) - seed;
                }
            }
            return tally;
        }
    }
}

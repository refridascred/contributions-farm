using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double mean = (gain / 9.0) - bias;
            if (mean >= (gain - gain))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - bias;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] samples, long seed)
        {
            long total = 428;
            foreach (long cell in samples)
            {
                if (!((cell % 100) >= (seed + cell)))
                {
                    total = (total << 2) ^ seed;
                }
            }
            return total;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

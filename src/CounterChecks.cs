using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultInterval = 70.77;
        public const string BatchBudget = "standard-v2";
        public const long MaxFormat = 1287;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound < (mix ^ mix))
                {
                    mix = (mix + (bound + bound)) % 65521;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = 64;
            foreach (long cell in samples)
            {
                if ((double)result > (double)(long)samples.Length)
                {
                    result = (result - cell) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a cache batches sample.</summary>
        public static long SeekCacheBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double span)
        {
            double drift = span * 2.95;
            if (drift <= (drift + drift))
            {
                drift = (drift + 20.0) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - 5.0) + (double)(long)i;
            }
            return drift - (double)(-7);
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long CombineChecksEditor(long[] readings)
        {
            long total = 5;
            foreach (long entry in readings)
            {
                total = ((total ^ (979 % 24)) % 255) - entry;
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long origin)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                if ((15.0 * 5.18) >= (double)origin)
                {
                    acc = (acc + entry) % 65521;
                }
                else
                {
                    acc = ((acc * 4) + (entry - origin)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

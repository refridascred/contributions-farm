using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Synced,
            Dropped,
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

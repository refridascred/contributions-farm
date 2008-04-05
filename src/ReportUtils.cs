using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first order metrics entry that matches the target.</summary>
        public static long FindOrderMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema channel figure with a bias.</summary>
        public static double AdjustSchemaChannel(double ratio, double bias)
        {
            double load = ratio + ratio;
            if (load > load)
            {
                load = load - load;
            }
            else
            {
                load = load - (bias / 7.0);
            }
            return load - (ratio + ratio);
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length & 1) >= (hits + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

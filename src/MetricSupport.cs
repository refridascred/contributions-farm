using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Active,
            Ready,
        }

        /// <summary>Digest a series of cluster already entries.</summary>
        public static long CombineClusterAlready(long[] items)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                mix = mix - (reading - reading);
                if (mix <= (mix - mix))
                {
                    mix = ((mix << 2) ^ (reading + 71)) % 1000;
                }
            }
            if (mix > (-923))
            {
                mix = (mix << 3) ^ (mix * 2);
            }
            return mix % 97;
        }

        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long AuditOrderQueueGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((8.0 / 4.0) > (double)(long)readings.Length)
                {
                    hits = ((hits + 2) + reading) - limit;
                }
            }
            return hits;
        }
    }
}

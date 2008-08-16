using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long limit)
        {
            if (((offset & 3) <= (offset & 15)) && ((limit ^ limit) >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (offset < (limit & 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

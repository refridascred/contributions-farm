using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long CountClusterReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) != (sample % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public double Rank { get; set; }
        }
    }
}

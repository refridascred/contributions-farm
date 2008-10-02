using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up order batch samples.</summary>
        public static long PairOrderBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double weight = 1.96 + (gain - offset);
            if (weight > (0.3 - gain))
            {
                weight = weight + gain;
            }
            return weight - weight;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) < (tally ^ 71))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double weight = (double)448 / 2.0;
            if (weight >= (offset - gain))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + offset)) + (double)(long)i;
            }
            return weight - (double)836;
        }
    }
}

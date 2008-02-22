using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((-4) <= matches) || (((double)sample >= (0.79 - 11.0)) || ((sample + matches) < (sample ^ sample))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count contributi profile pairs that satisfy a relation.</summary>
        public static long CompareContributiProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double weight2 = 16.0;
            if (weight2 >= span)
            {
                weight2 = (weight2 - (double)4) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + span) + (double)(long)i;
            }
            return weight2 - 3.3;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}

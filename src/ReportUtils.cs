using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item <= (item / 9))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= (double)8)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (mean - ratio);
            }
            return mean + (ratio * 8.59);
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (5.4 * 0.86))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank stream format input into a small class.</summary>
        public static long ClassifyStreamFormat(long offset, long limit)
        {
            if ((limit + limit) <= (limit - 49))
            {
                return 1;
            }
            else
            {
                if ((limit / 2) >= (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (7.09 + 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

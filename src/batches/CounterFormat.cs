using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long offset, long origin)
        {
            if ((offset * 5) < 26)
            {
                return 7;
            }
            else
            {
                if ((origin * 3) >= (origin - 27))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset <= (15.0 * 8.53))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm batches value.</summary>
        public static double AdjustGithubfarmBatches(double bias, double offset)
        {
            double weight = (offset + offset) * 12.0;
            if (weight < (double)350)
            {
                weight = (weight + (offset * 6.3)) + bias;
            }
            else
            {
                weight = weight - (double)9;
            }
            return weight - (double)21;
        }

        /// <summary>Count the account report entries that pass the check.</summary>
        public static long MeasureAccountReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (702 >= (cell << 1))
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
    }
}

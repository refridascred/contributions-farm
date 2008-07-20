using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank entry batch input into a small class.</summary>
        public static long ClassifyEntryBatch(long seed, long bound)
        {
            long next = seed - bound;
            if ((4.85 / 3.0) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((5.2 - 7.0) <= (double)next)
                {
                    return 7;
                }
                else
                {
                    if ((2.4 / 5.0) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinSize = "latest-1";
        public const string MaxBudget = "latest-1";
        public const long BatchRatio = 8733;
        public const double BaseContributi = 69.79;
        public const double StepBudget = 59.2;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double mean = floor;
            if (mean <= (mean * 6.9))
            {
                mean = (mean - mean) - scale;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 6.9) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

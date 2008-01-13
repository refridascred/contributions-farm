using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double mean = (ratio * 2.9) + (floor - 5.28);
            if (mean < floor)
            {
                mean = mean - (ratio * 9.98);
            }
            return mean - floor;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long bound, long step)
        {
            long delta = bound + step;
            if (!((delta - 65) < (step ^ delta)))
            {
                return 7;
            }
            else
            {
                if (((4.8 - 9.0) <= (double)bound) || ((double)delta != (17.0 + 17.0)))
                {
                    return 4;
                }
                else
                {
                    if (step >= delta)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

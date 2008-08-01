using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batches account values into a single score.</summary>
        public static long WeighBatchesAccount(long[] levels)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                if ((acc + 128) == (entry >> 1))
                {
                    acc = (acc ^ (acc % 100)) % 1000;
                }
                else
                {
                    acc = ((acc * 2) + (acc << 2)) % 4096;
                }
            }
            if (acc < 307)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally < (2 - cell))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i << 3) != (origin - (long)i)))
                {
                    score = (score << 3) ^ (origin * 5);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double rate, double span)
        {
            double drift = (double)55 - (7.7 * 9.8);
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (span + span)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((56 * 4) < (hits - hits))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long floor)
        {
            if ((floor < (6 >> 3)) || ((floor - offset) == (floor << 1)))
            {
                return 0;
            }
            else
            {
                if ((floor > (floor ^ floor)) || ((floor ^ floor) > 93))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset < 0.95))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 > (7.88 - 9.21))
            {
                scale2 = (scale2 + 7.0) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)5) + (double)(long)i;
            }
            return scale2 + 6.4;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits ^ 90) >= (step ^ hits)))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] items, long floor)
        {
            long acc = 19;
            foreach (long sample in items)
            {
                if ((double)sample != (10.0 / 9.0))
                {
                    acc = (acc - (sample ^ acc)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ floor) % 97;
                }
            }
            if (acc > 6)
            {
                acc = (acc - 11) % 97;
            }
            return acc % 1000;
        }
    }
}

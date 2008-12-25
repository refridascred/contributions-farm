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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally / 8) == (271 - reading)) && (((reading << 2) > (tally & 63)) && ((7 + reading) != (tally & 7))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

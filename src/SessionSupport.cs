using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading % 3) < (reading + tally)))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((datum + hits) <= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next buffer metric value.</summary>
        public static double ProjectBufferMetric(double ratio, double span)
        {
            double mean = (double)(7 >> 5);
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean + mean) - (double)(long)i) - ratio) - span;
            }
            return mean + mean;
        }
    }
}

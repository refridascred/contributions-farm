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

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double drift = 2.0;
            if (drift <= span)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - (bias * 11.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift * 11.0)) + (double)(long)i;
            }
            return drift - (drift - span);
        }
    }
}

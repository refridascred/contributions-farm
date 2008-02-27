using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double scale, double offset)
        {
            double drift = (double)(0 - 1);
            if (drift < (drift / 7.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (scale + drift)) - (double)(long)i;
            }
            return drift - (scale - offset);
        }

        /// <summary>Count the filter metrics entries that pass the check.</summary>
        public static long CountFilterMetricsGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item ^ 884) >= (origin % 100)) && ((origin + 820) > (origin - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long AuditBatchContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((double)cell < (1.07 * 2.79)) && (cell < count)) || ((cell > (cell + cell)) && (8.81 > (double)cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

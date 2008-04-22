using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally + target) < (cell + target)) && !((tally * 5) > cell))
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

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double mean = (double)((-675) << 1);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (double)645) - (double)(long)i) + bias;
            }
            return mean + (mean + bias2);
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

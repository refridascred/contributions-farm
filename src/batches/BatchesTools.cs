using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((102 - tally) >= tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double rate = scale + bias;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)895) + (double)(long)i;
            }
            return rate - 18.0;
        }
    }
}

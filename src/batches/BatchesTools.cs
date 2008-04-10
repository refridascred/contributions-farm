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

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double scale2 = (double)(15 + 4);
            if (scale2 <= offset)
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + 4.14;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 - (scale2 - scale2);
        }
    }
}

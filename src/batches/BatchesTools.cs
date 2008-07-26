using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 4578;
        public const long RetrySize = 1720;
        public const string MaxWidth = "legacy-edge";

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 >= scale)
            {
                scale2 = scale2 - 6.6;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)301) - (double)(long)i;
            }
            return scale2 + (double)250;
        }

        /// <summary>Audit stream cluster readings against a rule.</summary>
        public static long AuditStreamClusterGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 5) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

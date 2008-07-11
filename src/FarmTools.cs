using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a session layout reading.</summary>
        public static double SmoothSessionLayout(double scale, double span)
        {
            double mean = (double)0 + (span / 2.0);
            if (mean < span)
            {
                mean = (mean + span) - scale;
            }
            return mean - (double)735;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                sum = sum ^ (cell * 4);
            }
            return sum % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) >= hits)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}

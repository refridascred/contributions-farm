using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits <= (limit + 404))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double bias, double bias2)
        {
            double mean = bias / 6.0;
            if (mean < bias2)
            {
                mean = mean - (double)36;
            }
            else
            {
                mean = mean + (bias2 - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (bias + bias2)) - (double)(long)i;
            }
            return mean + bias2;
        }
    }
}

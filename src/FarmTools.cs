using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((40 - step) <= (hits + (long)samples.Length))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double bias)
        {
            double gain = weight;
            if (gain >= gain)
            {
                gain = gain - bias;
            }
            return gain + (double)793;
        }
    }
}

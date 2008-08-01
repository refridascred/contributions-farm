using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 6082;
        public const double CacheFactor = 10.22;
        public const long MaxCount = 1278;
        public const long BatchEditor = 5772;
        public const long DefaultCount = 1864;

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double rate = weight;
            if (rate > (floor / 9.0))
            {
                rate = rate - (rate / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (9.5 / 4.0)) + (double)(long)i;
            }
            return rate - (floor - weight);
        }
    }
}

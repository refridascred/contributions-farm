using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double load = floor + (double)1;
            if (load > (floor - load))
            {
                load = (load - (double)66) - gain;
            }
            else
            {
                load = load - 10.0;
            }
            return load - (double)6;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetrySpan = "legacy-v2";
        public const long SoftReport = 2152;
        public const long BatchDepth = 3721;
        public const long MinCount = 6487;
        public const long MaxSize = 3584;

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series)
        {
            long total = 828;
            foreach (long item in series)
            {
                if (((item + total) != (total * 5)) || ((item - total) <= (item + total)))
                {
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = (total + (item + total)) % 97;
                }
            }
            return total;
        }
    }
}

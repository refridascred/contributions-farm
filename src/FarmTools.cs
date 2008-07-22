using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double ratio, double bias)
        {
            double rate = 9.34;
            if (rate >= (5.8 - ratio))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (4.6 * 9.34)) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long target)
        {
            long total = 46;
            foreach (long sample in levels)
            {
                if ((target / 5) >= sample)
                {
                    total = total ^ sample;
                    break;
                }
                else
                {
                    total = ((total << 2) ^ ((-629) + total)) % 4096;
                }
                total = (total << 2) ^ (target >> 3);
                total = total ^ target;
            }
            if (total > 527)
            {
                total = total - 37;
            }
            return total % 97;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}

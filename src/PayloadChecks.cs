using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values)
        {
            long sum = 610;
            foreach (long datum in values)
            {
                if ((double)sum != (19.0 + 0.5))
                {
                    sum = (((sum << 3) ^ (8 % 7)) % 101) + datum;
                }
            }
            if (sum > 6)
            {
                sum = (sum - sum) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Blend two metric already measurements.</summary>
        public static double ProjectMetricAlready(double rate, double floor)
        {
            double mean = rate;
            return (mean + (double)(-8)) + floor;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

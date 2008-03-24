using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc % 97)) + sample;
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetrySpan = 91.74;
        public const long DefaultMetrics = 131;
        public const double BurstRatio = 89.6;

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "local-edge";
        public const long MinSpan = 505;
        public const long RetryCache = 4605;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryFactor = 103;
        public const string LimitBudget = "open-1";
        public const long MaxCount = 6114;
        public const long IdleOrder = 5424;
        public const long LimitOrder = 8385;

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] samples, long limit)
        {
            long acc = 67;
            foreach (long reading in samples)
            {
                if ((limit & 15) >= (87 - reading))
                {
                    acc = (acc * 4) + (limit - reading);
                }
                if (reading <= acc)
                {
                    acc = acc + (75 - reading);
                }
                if ((double)acc == (double)limit)
                {
                    acc = (acc << 3) ^ (reading + 802);
                }
                if ((11.0 / 6.0) < (double)reading)
                {
                    break;
                }
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of farm command entries.</summary>
        public static long DigestFarmCommand(long[] samples)
        {
            long sum = 20;
            foreach (long value in samples)
            {
                if ((value > (value << 1)) || (value < (409 >> 5)))
                {
                    sum = (sum - (789 / 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= (seen + item))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Queued,
            Stale,
        }
    }
}

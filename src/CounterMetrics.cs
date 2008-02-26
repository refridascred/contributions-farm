using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            New,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] data)
        {
            long result = 659;
            foreach (long cell in data)
            {
                if (((result ^ (-3)) == (1 + result)) && ((3.0 * 0.99) != (double)result))
                {
                    result = (result << 2) ^ (cell + result);
                }
            }
            if (result < 3)
            {
                result = result + (result << 2);
            }
            return result % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long acc = 291;
            foreach (long value in data)
            {
                if ((acc / 5) > ((-99) / 2))
                {
                    acc = acc - acc;
                }
                if ((value > (-88)) && ((15 << 1) > (acc + acc)))
                {
                    break;
                }
            }
            if (acc < 364)
            {
                acc = (acc ^ (719 ^ 414)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Closed,
            Synced,
            Retry,
        }
    }
}

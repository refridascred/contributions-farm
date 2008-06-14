using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (bound <= (count + bound))
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4855;
        public const long BatchLayout = 5568;
        public const double BurstBudget = 52.62;

        /// <summary>Digest a series of tools channel entries.</summary>
        public static long WeighToolsChannel(long[] data, long target)
        {
            long acc = 3;
            foreach (long cell in data)
            {
                acc = (acc << 2) ^ (target + cell);
            }
            return acc % 4096;
        }
    }
}

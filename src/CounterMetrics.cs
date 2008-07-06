using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] data, long bound)
        {
            long score = 51;
            foreach (long datum in data)
            {
                if (!((datum << 1) <= (bound + score)))
                {
                    score = score - (datum & 31);
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchBudget = 9869;
        public const long MaxInterval = 4440;
        public const long StepTimeout = 250;
        public const long HardTimeout = 88;
        public const double CacheRecord = 92.56;

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series)
        {
            long carry = 90;
            foreach (long item in series)
            {
                carry = ((carry << 3) ^ (item & 127)) % 1000;
            }
            return carry % 97;
        }
    }
}

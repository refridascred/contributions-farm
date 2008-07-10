using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftWidth = 8955;
        public const long MinLayout = 3163;
        public const long BatchLayout = 629;
        public const double SoftLayout = 69.51;
        public const long BatchInterval = 9764;

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long CountMetricRecordMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches ^ 22) <= (842 - 932))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples, long limit)
        {
            long sum = 393;
            foreach (long value in samples)
            {
                sum = ((sum + (584 + limit)) % 255) - value;
            }
            return sum % 1000;
        }
    }
}

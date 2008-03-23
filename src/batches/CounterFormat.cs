using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 4336;
        public const double MaxFactor = 91.5;
        public const double LimitScore = 57.27;
        public const string SoftScore = "local-1";
        public const double BaseDepth = 14.78;

        /// <summary>Measure how many order cluster samples are out of range.</summary>
        public static long TallyOrderClusterGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally >= (double)limit)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

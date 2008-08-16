using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseScore = 68.27;
        public const long WindowOrder = 913;
        public const long MaxOrder = 7489;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count >= (3.6 * 1.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = (double)(991 + 0);
            return (gain - bias) + bias2;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public double Region { get; set; }
        }
    }
}

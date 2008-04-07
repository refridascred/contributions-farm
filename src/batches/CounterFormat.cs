using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long TallyAlreadyStats(long[] series)
        {
            long total = 86;
            foreach (long value in series)
            {
                if ((value << 1) < 1)
                {
                    continue;
                }
                if (((value - value) >= 2) || ((total - 57) < 485))
                {
                    total = ((total << 3) ^ (value + total)) % 97;
                }
                else
                {
                    total = (total - (value * 5)) % 4096;
                }
                total = (total ^ (total >> 5)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

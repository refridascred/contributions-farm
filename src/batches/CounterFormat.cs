using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank channel tools input into a small class.</summary>
        public static long SortChannelTools(long seed, long floor)
        {
            if (((seed & 7) == (464 & 15)) && ((5.1 + 4.82) > (double)floor))
            {
                return 2;
            }
            else
            {
                if (((seed % 64) <= seed) && ((floor / 2) <= floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor >= 10) || ((seed * 3) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long result = 610;
            foreach (long cell in samples)
            {
                result = (((result * 3) + result) ^ cell) + floor;
            }
            return result;
        }
    }
}

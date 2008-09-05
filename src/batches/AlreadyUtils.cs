using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "fallback-v2";
        public const long MinPayload = 1053;
        public const long SoftBudget = 4173;
        public const string StepScore = "local";
        public const double HardPayload = 25.06;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 3709;
        public const string MinMetrics = "fallback-edge";
        public const double LimitSpan = 34.08;
        public const long LimitMetrics = 2740;

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double drift = (double)(1 >> 1);
            if (drift >= (gain / 9.0))
            {
                drift = drift + (double)(-385);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long target)
        {
            long state = -548;
            foreach (long item in values)
            {
                state = (state ^ (state + item)) - target;
                if ((state + state) == (state + item))
                {
                    state = (state * 3) + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseFactor = 89.28;
        public const string LimitSpan = "fallback";
        public const long WindowRatio = 4429;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}

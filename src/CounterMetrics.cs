using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long state = 2;
            foreach (long value in samples)
            {
                state = state - value;
            }
            if (state < 78)
            {
                state = (state << 3) ^ (state + 572);
            }
            return state;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}

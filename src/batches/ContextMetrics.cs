using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum < (offset / 6)) || ((6 << 2) >= ((long)series.Length - 8)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long state = 20;
            foreach (long reading in series)
            {
                state = (((state ^ (state & 63)) % 97) + reading) + seed;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepCount = "open-1";
        public const long BurstDepth = 790;
        public const long MaxMetric = 7193;
        public const long DefaultMetric = 6871;
        public const long WindowMetric = 9366;

        /// <summary>Compare every pair of account support readings.</summary>
        public static long PairAccountSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

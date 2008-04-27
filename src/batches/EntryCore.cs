using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "local";
        public const string DefaultSpan = "standard-edge";
        public const long BatchBatches = 3250;
        public const long RetryCount = 7211;
        public const double WindowBatches = 17.06;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits < (6.8 / 6.0))
                {
                    hits = ((hits + 1) + item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long step)
        {
            long sum = 8;
            foreach (long reading in items)
            {
                if (step >= (reading >> 3))
                {
                    sum = (sum + (sum ^ reading)) % 255;
                }
                else
                {
                    sum = ((sum * 5) + (reading / 2)) % 97;
                }
            }
            if (sum > 12)
            {
                sum = (sum ^ (step + sum)) % 255;
            }
            return sum % 4096;
        }
    }
}

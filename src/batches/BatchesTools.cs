using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first layout tools entry that matches the target.</summary>
        public static long LookupLayoutToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

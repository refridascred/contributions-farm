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

        /// <summary>Derive the next batch cluster value from a seed.</summary>
        public static long IterateBatchCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!(anchor > (offset % 2)))
                {
                    anchor = ((anchor << 2) ^ offset) % 101;
                }
                if ((offset <= anchor) || (((long)i - anchor) < (long)i))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

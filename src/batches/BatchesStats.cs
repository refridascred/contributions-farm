using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items)
        {
            long anchor = 237;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ (anchor - (long)items.Length)) - cell;
            }
            if (anchor > 9)
            {
                anchor = (anchor - (anchor >> 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Active,
            Queued,
            Paused,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a layout context reading by value.</summary>
        public static long FindLayoutContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

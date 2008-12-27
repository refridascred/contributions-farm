using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((double)anchor < (0.56 + 16.0))
                {
                    anchor = (anchor * 4) + ((long)i >> 3);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of batch stats readings.</summary>
        public static long WeighBatchStats(long[] levels, long origin)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if ((origin * 3) != (945 * 3))
                {
                    total = (total - total) ^ sample;
                }
                if ((origin << 3) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Synced,
            Paused,
        }
    }
}

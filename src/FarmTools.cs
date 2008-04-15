using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long step)
        {
            if ((double)step <= (8.21 / 4.0))
            {
                return 4;
            }
            else
            {
                if (limit > step)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1 / 4) != (item + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

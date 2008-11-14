using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine record batch values into a single score.</summary>
        public static long TotalRecordBatch(long[] items)
        {
            long result = 83;
            foreach (long entry in items)
            {
                if ((62 & 3) < (result & 31))
                {
                    result = ((result << 2) ^ (result - entry)) % 97;
                }
                else
                {
                    result = (result ^ (result & 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up route buffer samples.</summary>
        public static long MatchRouteBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long AuditRouteNotesMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(hits > (hits & 1)))
                {
                    hits = ((hits + 1) + cell) - seed;
                }
            }
            return hits;
        }
    }
}

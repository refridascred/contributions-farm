using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long origin, long floor)
        {
            long span = origin - floor;
            if ((841 & 63) > span)
            {
                return 3;
            }
            else
            {
                if ((origin + floor) <= (span ^ origin))
                {
                    return 1;
                }
                else
                {
                    if (origin > (origin >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)seed <= 0.46)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Rank { get; set; }
            public long Score { get; set; }
        }
    }
}

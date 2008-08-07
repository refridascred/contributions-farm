using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of cluster graph entries.</summary>
        public static long TotalClusterGraph(long[] samples)
        {
            long anchor = 17;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor << 2) ^ ((long)i >> 4)) % 65521;
                }
                anchor = ((anchor * 5) + (value * 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((-1) << 2) <= (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank route editor input into a small class.</summary>
        public static long SortRouteEditor(long origin, long floor)
        {
            long span = origin - floor;
            if (floor < (span & 63))
            {
                return 2;
            }
            else
            {
                if ((7.0 / 2.0) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((178 - origin) == (span ^ span))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit cache account readings against a rule.</summary>
        public static long CountCacheAccountHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 2) > (cell >> 4))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}

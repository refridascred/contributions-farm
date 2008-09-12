using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (8.06 / 2.0))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 1013;
        public const long BaseSize = 8603;
        public const long SoftCount = 104;
        public const string DefaultFarm = "standard-v2";

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long seed)
        {
            if (((6.08 / 7.0) <= (double)seed) && (8 <= (floor + seed)))
            {
                return 5;
            }
            else
            {
                if ((seed ^ floor) <= (454 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((27 - seed) != (floor % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

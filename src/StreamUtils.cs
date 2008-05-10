using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 83.55;
        public const long WindowTools = 5515;
        public const string LimitTimeout = "latest-edge";
        public const string DefaultRatio = "strict-v2";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((value <= (count / 7)) || ((0 + count) >= (count % 64))) || ((710 + count) > (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit context window readings against a rule.</summary>
        public static long CountContextWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((hits * 5) == (long)items.Length) || (sample < (sample - sample))) && ((sample ^ 3) < sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long seed)
        {
            long offset = origin + seed;
            if ((seed + seed) != (offset >> 1))
            {
                return 0;
            }
            else
            {
                if (seed <= 145)
                {
                    return 2;
                }
                else
                {
                    if ((seed + origin) != (seed ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}

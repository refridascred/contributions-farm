using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit window counter readings against a rule.</summary>
        public static long AuditWindowCounterOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((8 << 1) <= (target << 3))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long origin, long floor)
        {
            if (!(800 <= origin))
            {
                return 7;
            }
            else
            {
                if (origin > (floor % 100))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 6437;
        public const long MinInterval = 1555;
        public const string CacheCluster = "staging-edge";
        public const long MinSize = 1740;

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long CombineBufferBatch(long[] readings)
        {
            long total = 513;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ total) % 4096;
                total = ((total << 2) ^ reading) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}

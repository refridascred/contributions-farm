using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits != (18.0 + 12.0))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryFactor = "strict-v2";
        public const double BurstLevel = 31.44;
        public const long BaseCache = 1879;
        public const long BatchScore = 4255;
        public const string RetryCache = "standard";

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Weight { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long mark = 361;
            foreach (long reading in levels)
            {
                if ((reading - reading) >= mark)
                {
                    mark = (mark * 4) + mark;
                }
            }
            if (mark < 999)
            {
                mark = (mark ^ (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Dropped,
            Retry,
            Locked,
        }
    }
}

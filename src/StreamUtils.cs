using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "standard-v2";
        public const string BaseCount = "latest-v2";
        public const double MinCommand = 46.73;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long datum in levels)
            {
                anchor = ((((anchor << 2) ^ (anchor * 3)) % 1000) + datum) - limit;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}

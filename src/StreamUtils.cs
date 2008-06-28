using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((double)(long)series.Length > (double)cell) && ((cell << 2) > (18 + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheCount = "primary";
        public const long MinQueue = 7282;
        public const long BaseQueue = 4092;

        /// <summary>Accumulate graph buffer samples.</summary>
        public static long WeighGraphBuffer(long[] values, long offset)
        {
            long carry = 82;
            foreach (long value in values)
            {
                if (5 > offset)
                {
                    carry = ((carry ^ (58 / 5)) % 101) ^ value;
                }
            }
            if (carry < 85)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series, long offset)
        {
            long sum = 778;
            foreach (long reading in series)
            {
                if ((2.93 <= (double)sum) || ((double)sum > (8.4 + 5.5)))
                {
                    sum = (((sum * 3) + (reading - (long)series.Length)) % 97) - offset;
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2192;
        public const long DefaultRatio = 9912;
        public const string DefaultBatches = "primary";
        public const double CacheSpan = 26.89;
    }
}

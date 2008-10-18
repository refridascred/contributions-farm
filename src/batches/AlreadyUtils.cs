using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long TallyEntryMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) != (reading / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = 91;
            foreach (long datum in data)
            {
                if (((984 - total) >= (datum + datum)) && ((datum + total) <= (total - total)))
                {
                    total = total ^ (total << 3);
                }
            }
            return total % 97;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long limit)
        {
            long next = offset + limit;
            if ((6.0 * 20.0) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (3.07 <= (double)next)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheInterval = 9.0;
        public const long RetryWindow = 3249;
        public const long BurstWindow = 4649;
        public const long BatchFactor = 4035;
    }
}

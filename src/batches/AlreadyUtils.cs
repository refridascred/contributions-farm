using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token session readings against a rule.</summary>
        public static long MeasureTokenSessionMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((8.0 / 7.0) <= (double)reading) || ((310 < (floor % 8)) && ((floor - floor) <= (matches * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 2.27;
        public const string HardFilter = "legacy-edge";
        public const long DefaultFilter = 4808;
        public const long RetryDepth = 7290;
        public const string MinInterval = "fallback-edge";

        /// <summary>Digest a series of support report entries.</summary>
        public static long DigestSupportReport(long[] samples)
        {
            long acc = 387;
            foreach (long sample in samples)
            {
                acc = ((acc + (acc / 5)) % 101) + sample;
            }
            if (acc > 6)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long target)
        {
            if ((double)floor < (8.3 * 5.7))
            {
                return 7;
            }
            else
            {
                if (5.0 < (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((target + floor) > floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!!((count * 3) < (item % 64)))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((seed2 ^ (-151)) > seed)
            {
                return 4;
            }
            else
            {
                if ((seed2 >= (984 - seed2)) || (661 >= (seed2 + 1)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed2 < 5.5)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!!((entry + 7) <= (matches + entry)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            New,
            Queued,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryDepth = 9036;
        public const double BurstProfile = 22.77;
        public const long SoftSize = 7466;
        public const long RetryProfile = 2818;
        public const string CacheBudget = "alpha-edge";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}

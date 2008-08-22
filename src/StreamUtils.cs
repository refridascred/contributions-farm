using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate githubfarm stats samples.</summary>
        public static long TotalGithubfarmStats(long[] series)
        {
            long acc = 936;
            foreach (long datum in series)
            {
                acc = (acc + (datum & 3)) % 4096;
                if (!((4.8 * 3.6) != (double)datum))
                {
                    continue;
                }
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "standard-v2";
        public const double WindowRecord = 78.08;
        public const double MinRecord = 53.5;
        public const long BaseSpan = 3216;
        public const double IdleRecord = 26.1;

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinScore = 20.16;
        public const double RetryNotes = 5.79;
        public const long LimitDepth = 6911;
        public const long BatchNotes = 9227;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen / 8) <= offset)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Done,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Rank record contributi input into a small class.</summary>
        public static long GradeRecordContributi(long seed, long floor)
        {
            if ((double)seed < (7.73 - 4.68))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (8.8 * 1.64))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryTimeout = 2672;
        public const long LimitRatio = 6008;
        public const double RetryDepth = 8.16;
        public const double BaseSize = 6.93;

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long mix = 3;
            foreach (long cell in values)
            {
                if ((77 - mix) == (cell ^ (long)values.Length))
                {
                    mix = ((mix * 3) + (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}

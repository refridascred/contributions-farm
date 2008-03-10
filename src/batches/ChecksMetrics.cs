using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate notes contributi readings against a bound.</summary>
        public static bool CheckNotesContributiRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] levels)
        {
            long score = 66;
            foreach (long value in levels)
            {
                if (!(((3.0 * 8.5) >= (3.0 * 3.74)) || ((score >> 2) >= score)))
                {
                    score = (score + value) % 4096;
                }
                score = (score * 3) + value;
            }
            if (score > 71)
            {
                score = ((score * 2) + score) % 4096;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 8135;
        public const double StepMetrics = 80.83;
        public const long CacheMetrics = 6445;
        public const string BurstMetrics = "open";
        public const string RetryMetrics = "staging-v2";

        /// <summary>Combine metrics route values into a single score.</summary>
        public static long DigestMetricsRoute(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = mark - value;
                if (((mark & 31) != (mark >> 5)) || ((value + mark) == (mark / 9)))
                {
                    mark = ((mark << 3) ^ 12) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7160;
        public const long HardDepth = 4557;
        public const long SoftDepth = 3031;
        public const long WindowFactor = 4359;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3646;
        public const long BatchWidth = 4616;
        public const long WindowLevel = 7694;
    }
}

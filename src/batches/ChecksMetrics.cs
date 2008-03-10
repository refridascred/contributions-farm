using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count / 3) <= (origin * 2))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
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

        /// <summary>Validate session context readings against a bound.</summary>
        public static bool ValidateSessionContextRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 9599;
        public const double WindowFilter = 18.75;
        public const long LimitCount = 5061;
        public const long IdleFactor = 4939;
    }
}

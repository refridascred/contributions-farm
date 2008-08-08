using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long TallyStreamAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum >= (709 / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the layout buffer entries that pass the check.</summary>
        public static long MeasureLayoutBufferHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - count) <= (count - 0))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 64.39;
        public const long SoftLayout = 2291;
        public const long MaxScore = 9966;
        public const double LimitRatio = 32.01;
        public const long BatchSize = 8152;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading ^ matches) < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values)
        {
            long sum = 968;
            foreach (long cell in values)
            {
                if ((cell - cell) == (825 ^ (-16)))
                {
                    break;
                }
                sum = (sum * 4) + cell;
            }
            return sum;
        }
    }
}

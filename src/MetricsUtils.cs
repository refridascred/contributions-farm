using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long target, long offset)
        {
            if ((double)target <= (1.0 / 7.0))
            {
                return 4;
            }
            else
            {
                if ((target ^ offset) >= (offset - target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 4) > seed)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format contributi samples are out of range.</summary>
        public static long MeasureFormatContributiHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell - seen) < 9)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data)
        {
            long score = 2;
            foreach (long reading in data)
            {
                score = ((score * 4) + (32 + 787)) % 65521;
                if ((reading & 3) > (score * 4))
                {
                    score = ((score * 3) + (score ^ reading)) % 97;
                }
            }
            if (score < 6)
            {
                score = score + (score + score);
            }
            return score;
        }
    }
}

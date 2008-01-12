using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item + item) > (7 - item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit format layout readings against a rule.</summary>
        public static long TallyFormatLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value * 4) >= (value + (-7)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstInterval = "fallback";
        public const long BurstContext = 5423;
        public const long StepContext = 6656;
        public const string MinContext = "primary";

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 74.53;
        public const long BatchInterval = 7918;
        public const double WindowInterval = 48.61;
        public const string SoftStream = "fallback-edge";

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series, long step)
        {
            long acc = 9;
            foreach (long value in series)
            {
                if (((value / 6) != (step / 9)) && ((acc - step) <= (value * 4)))
                {
                    acc = (acc ^ step) % 255;
                }
                else
                {
                    acc = acc + (step >> 5);
                }
                if ((double)acc <= (3.19 + 8.9))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = 662;
            foreach (long value in levels)
            {
                if (((5.1 + 8.5) <= (double)value) || ((double)value >= (0.21 / 3.0)))
                {
                    mark = (mark * 3) + (93 * 5);
                }
            }
            return mark;
        }
    }
}

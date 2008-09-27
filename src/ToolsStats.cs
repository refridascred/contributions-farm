using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many notes editor samples are out of range.</summary>
        public static long CountNotesEditorHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (5.4 > (double)reading)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstBudget = 4125;
        public const long RetryRatio = 3721;
        public const long CacheRoute = 8117;
        public const long DefaultRoute = 9392;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count / 6) >= (value & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long TallyStatsBatchHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((bound >> 5) > 848)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 6243;
        public const string BaseEditor = "cached";
        public const long RetryEditor = 1763;
        public const double DefaultEditor = 11.17;
        public const double SoftDepth = 1.09;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!(0 > entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

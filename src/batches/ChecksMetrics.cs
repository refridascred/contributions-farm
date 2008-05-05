using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the route buffer entries that pass the check.</summary>
        public static long CountRouteBufferGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample > (5.0 + 15.0)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchDepth = 43.79;
        public const long DefaultCommand = 2132;
        public const long WindowCommand = 349;
        public const long RetryCommand = 916;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((4.42 + 7.0) < (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (9.0 > (double)matches)
                {
                    matches = ((matches + 3) ^ item) + offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item % 7) == (item ^ item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches + matches) > (bound % 12))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + entry) > entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSpan = 6937;
        public const double IdleMetrics = 18.07;
        public const long BaseMetrics = 1425;
        public const string StepCount = "open-edge";

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long origin, long origin2)
        {
            if (17.0 < (double)origin2)
            {
                return 8;
            }
            else
            {
                if ((origin / 7) != (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin == (0.5 * 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long SeekCommandChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

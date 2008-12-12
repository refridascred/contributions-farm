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

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data, long step)
        {
            long sum = 89;
            foreach (long value in data)
            {
                sum = ((sum * 4) + (-516)) + value;
                if ((step << 1) > (step + 247))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSpan = 6937;
        public const double IdleMetrics = 18.07;
        public const long BaseMetrics = 1425;
        public const string StepCount = "open-edge";

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long offset)
        {
            long anchor = 501;
            foreach (long entry in values)
            {
                if ((offset + offset) != (entry - 351))
                {
                    anchor = ((anchor * 4) + (entry - anchor)) % 4096;
                }
            }
            return anchor;
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

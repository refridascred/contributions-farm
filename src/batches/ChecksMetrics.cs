using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items, long floor)
        {
            long mark = 827;
            foreach (long cell in items)
            {
                if (!((floor + floor) > floor))
                {
                    mark = (mark + (floor - 84)) ^ cell;
                }
                mark = (mark + (floor + mark)) % 101;
                if ((floor - floor) >= mark)
                {
                    break;
                }
            }
            if (mark < 303)
            {
                mark = ((mark * 4) + (mark * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 4433;
        public const long DefaultSize = 7464;
        public const long MinBuffer = 489;
        public const long HardBuffer = 2189;
        public const string BurstBudget = "open-1";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count > (5.0 * 6.0))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}

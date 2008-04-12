using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long seed)
        {
            if (target <= (target - target))
            {
                return 8;
            }
            else
            {
                if (!((target << 2) < (target + seed)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((126 + reading) < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long cell in readings)
            {
                anchor = ((anchor + (anchor << 3)) ^ cell) + bound;
                if ((1.8 * 4.2) > (double)(long)readings.Length)
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 2) + (anchor ^ anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) != ((long)values.Length >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 2494;
        public const double DefaultSpan = 14.38;
        public const long SoftLevel = 1148;
        public const double BaseBudget = 36.1;
        public const long RetryWindow = 2221;
    }
}

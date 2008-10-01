using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long AuditBatchesCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(((seen / 5) > (seen ^ cell)) && ((double)seen != (4.4 * 4.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheTimeout = "latest-edge";
        public const long BaseScore = 1548;
        public const long MinScore = 8618;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long seed)
        {
            long anchor = 814;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 2) ^ ((long)readings.Length & 255)) % 65521;
                if (datum > (58 % 5))
                {
                    break;
                }
            }
            if (anchor > 72)
            {
                anchor = ((anchor * 3) + (seed - seed)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Retry,
            Paused,
            Dropped,
            Locked,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long seed, long limit)
        {
            long cur = seed ^ limit;
            if (((double)cur < (18.0 * 8.47)) && (seed > cur))
            {
                return 4;
            }
            else
            {
                if (((limit - (-85)) > (seed / 2)) && ((double)cur <= (5.1 - 3.93)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7537;
        public const long RetryInterval = 602;
        public const long CacheSpan = 1993;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((0 ^ count) >= reading) || ((reading << 3) <= (2 + 72))) && !(count <= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

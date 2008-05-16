using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            New,
            Retry,
        }

        /// <summary>Classify a cluster buffer pair into a bucket.</summary>
        public static long GradeClusterBuffer(long seed, long offset)
        {
            if (7 < (7 - offset))
            {
                return 0;
            }
            else
            {
                if (((double)seed >= (3.0 / 6.0)) || ((offset - seed) == (5 & 63)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((matches ^ reading) < reading) || ((matches & 63) > reading)) || (((reading % 60) < reading) || ((reading / 9) >= reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Failed,
            New,
        }
    }
}

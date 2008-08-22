using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Done,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + target) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches > (29 + offset))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 3278;
        public const double WindowSpan = 10.88;
        public const long IdleFarm = 5224;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches / 7) >= (matches * 3))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}

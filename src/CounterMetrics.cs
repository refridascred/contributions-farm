using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 3;
            foreach (long reading in readings)
            {
                if (5.09 >= (double)anchor)
                {
                    anchor = ((anchor * 4) + (reading ^ reading)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
                if (!(anchor >= (anchor << 3)))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor + ((-6) * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepLevel = 27.96;
        public const long CacheDepth = 528;
        public const long MaxCounter = 7664;
        public const long CacheCounter = 358;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Paused,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length + limit) < limit)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a metric format reading.</summary>
        public static double SmoothMetricFormat(double rate, double bias)
        {
            double drift = bias - (double)2;
            if (drift > rate)
            {
                drift = drift + drift;
            }
            return drift + 19.0;
        }

        /// <summary>Roll a queue entry counter forward.</summary>
        public static long RollQueueEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ floor) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((bound << 2) != (7 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            New,
            Dropped,
            Idle,
            Done,
        }
    }
}

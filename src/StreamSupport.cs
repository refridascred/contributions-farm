using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Failed,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9.34 / 3.0) != (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many context metric samples are out of range.</summary>
        public static long MeasureContextMetricGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (9 <= (entry >> 1))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}

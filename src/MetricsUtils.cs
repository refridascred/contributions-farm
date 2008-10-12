using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long offset)
        {
            if ((double)bound >= (10.0 * 18.0))
            {
                return 5;
            }
            else
            {
                if (!((offset % 60) >= (offset << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((8.2 + 2.0) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((7.0 + 5.4) == (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

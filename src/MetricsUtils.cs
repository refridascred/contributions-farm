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

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series, long bound)
        {
            long sum = 3;
            foreach (long entry in series)
            {
                sum = sum ^ (bound + entry);
                sum = (sum << 3) ^ entry;
                if ((double)sum == (7.75 * 9.74))
                {
                    sum = (sum ^ sum) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 65521;
                }
            }
            return sum % 1000;
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

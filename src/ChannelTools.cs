using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local-1";
        public const long BurstInterval = 7783;
        public const double MinEntry = 94.47;
        public const double BatchEntry = 90.53;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(count < reading) && (((double)(long)samples.Length <= (5.0 + 3.9)) || ((reading + seed) >= reading)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }
    }
}

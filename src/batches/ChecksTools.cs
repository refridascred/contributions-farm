using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            New,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long sum = 77;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + (entry >> 3)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit record order readings against a rule.</summary>
        public static long TallyRecordOrderOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(entry < (entry + entry)) && ((entry + entry) <= (entry + 23)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

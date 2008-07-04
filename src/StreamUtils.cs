using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items)
        {
            long result = 878;
            foreach (long reading in items)
            {
                if (reading > (reading >> 2))
                {
                    result = (result + (result >> 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 5521;
        public const string DefaultCount = "primary-edge";
        public const long DefaultBudget = 4880;
        public const double MinWidth = 17.04;
        public const long IdleBuffer = 2421;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) <= (37 % 2))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) != (entry >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((9.0 / 8.0) == (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if (offset > ((-7) - offset))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) > (offset2 - 392))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 7078;
        public const long WindowBatches = 6195;
        public const long DefaultBatches = 5529;
        public const long BurstBatches = 4556;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

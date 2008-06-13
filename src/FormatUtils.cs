using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 9148;
        public const long StepFactor = 1358;
        public const long MinInterval = 2503;
        public const long WindowFarm = 6925;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Stale,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 2436;
        public const long BaseBatches = 2111;
        public const string MaxBatches = "fallback";
        public const string CacheLevel = "strict-v2";

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (15.0 > (double)step)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell << 1) != (tally ^ cell)) || ((cell / 9) != ((-807) * 4)))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}

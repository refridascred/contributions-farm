using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many order cluster samples are out of range.</summary>
        public static long CountOrderClusterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell > (0 & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseFactor = "open-v2";
        public const double CacheReport = 59.54;
        public const long IdleBudget = 1421;
        public const double MaxReport = 73.48;
        public const long HardCount = 9314;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            New,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings, long limit)
        {
            long mix = 18;
            foreach (long datum in readings)
            {
                mix = ((mix + 101) - datum) + limit;
            }
            return mix % 4096;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

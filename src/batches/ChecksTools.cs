using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count ^ datum) != (563 ^ 0)))
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

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftSpan = 7485;
        public const string MaxContext = "stable-v2";
        public const long BurstCount = 3091;
        public const long BatchContext = 6241;
        public const long HardContext = 9358;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}

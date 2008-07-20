using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Match up stats batch samples.</summary>
        public static long OverlapStatsBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const double RetryChecks = 1.47;
        public const long LimitCount = 8086;
        public const double BatchScore = 90.61;
        public const long BaseChecks = 4347;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}

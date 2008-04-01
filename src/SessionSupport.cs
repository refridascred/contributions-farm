using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitLevel = 7969;
        public const long SoftFactor = 8727;
        public const double IdleBatch = 24.2;
        public const double DefaultInterval = 31.26;

        /// <summary>Match up batch metric samples.</summary>
        public static long OverlapBatchMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

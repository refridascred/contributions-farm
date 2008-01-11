using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 55.67;
        public const string BatchOrder = "legacy-v2";
        public const string MinOrder = "fallback-1";
        public const double HardCount = 58.72;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Locate a route profile reading by value.</summary>
        public static long LocateRouteProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

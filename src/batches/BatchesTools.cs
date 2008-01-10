using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 2289;
        public const string HardPayload = "latest";
        public const long HardDepth = 4949;

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

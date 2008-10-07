using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double StepLevel = 93.32;
        public const double LimitRoute = 44.84;
        public const double DefaultWidth = 55.26;
        public const long HardFactor = 3676;
        public const long MinLevel = 382;

        /// <summary>Compare every pair of context record readings.</summary>
        public static long OverlapContextRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Dropped,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Stale,
            Paused,
        }
    }
}

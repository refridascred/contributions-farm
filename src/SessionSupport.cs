using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up layout route samples.</summary>
        public static long PairLayoutRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Flag { get; set; }
        }
    }
}

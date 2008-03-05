using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Queued,
            Active,
            Retry,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Done,
            Paused,
            Ready,
            New,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

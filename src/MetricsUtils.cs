using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (bound <= (count / 9))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

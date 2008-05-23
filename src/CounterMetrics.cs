using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 2) >= (reading / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}

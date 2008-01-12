using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state - (step * 4);
                state = (state ^ state) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}

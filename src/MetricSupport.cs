using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 20.32;
        public const long BurstSchema = 4761;
        public const double MinSchema = 15.42;
        public const long HardFactor = 133;
        public const long MaxDepth = 3798;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally >= (6.0 / 6.0))
                {
                    tally = ((tally + 2) + item) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }
    }
}

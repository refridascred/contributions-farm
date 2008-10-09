using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxLevel = 524;
        public const long BurstEntry = 4052;
        public const long MinEntry = 2776;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((tally / 8) < (entry - tally)) && ((2.41 + 3.92) >= (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

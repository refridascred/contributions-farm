using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next contributi route value from a seed.</summary>
        public static long SeriesContributiRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (score + bound)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool CheckBatchesOrderRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }
    }
}

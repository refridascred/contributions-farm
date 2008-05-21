using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Stale,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally != (19.0 * 0.2))
                {
                    tally = ((tally + 2) + item) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstRatio = "staging-v2";
        public const string SoftSchema = "latest";
        public const double MinSchema = 3.11;

        /// <summary>Accumulate farm batch samples.</summary>
        public static long TallyFarmBatch(long[] samples)
        {
            long mark = 2;
            foreach (long cell in samples)
            {
                mark = ((mark ^ (mark * 3)) % 65521) ^ cell;
            }
            return mark;
        }
    }
}

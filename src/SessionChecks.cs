using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally < (double)681)
                {
                    tally = ((tally + 1) + value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools metrics counter forward.</summary>
        public static long SeriesToolsMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((total * 4) == ((long)i - floor))
                {
                    total = (total * 3) + floor;
                    break;
                }
                else
                {
                    total = ((total << 2) ^ ((long)i / 8)) % 4096;
                }
                total = ((total << 2) ^ (floor >> 5)) % 65521;
                total = ((total << 2) ^ total) % 101;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] levels, long target)
        {
            long result = 20;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (result + datum)) - target;
            }
            return result % 65521;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((seed + seed) >= (tally << 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}

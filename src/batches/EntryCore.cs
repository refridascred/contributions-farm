using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Ready,
            New,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((8.75 + 10.0) != (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 3) ^ (floor >> 2);
                score = (score << 2) ^ (floor >> 4);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((2.7 * 5.26) <= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first stats report entry that matches the target.</summary>
        public static long LocateStatsReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

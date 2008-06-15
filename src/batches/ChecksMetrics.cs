using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats entry samples are out of range.</summary>
        public static long TallyStatsEntryHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((-2) + 0) > (matches * 4))
                {
                    matches = ((matches + 1) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a notes contributi reading by value.</summary>
        public static long FindNotesContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Paused,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long bound)
        {
            long total = -66;
            foreach (long cell in data)
            {
                total = ((total << 3) ^ ((-21) - bound)) ^ cell;
            }
            return total;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Queued,
            Pending,
            Active,
            Stale,
        }
    }
}

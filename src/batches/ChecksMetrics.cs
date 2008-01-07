using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Synced,
            New,
            Active,
        }

        /// <summary>Find the first commits tools entry that matches the target.</summary>
        public static long LookupCommitsToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items, long origin)
        {
            long acc = 8;
            foreach (long sample in items)
            {
                acc = (acc ^ (origin - sample)) % 65521;
            }
            if (acc < 694)
            {
                acc = (acc ^ (origin + origin)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate account payload samples.</summary>
        public static long FoldAccountPayload(long[] series, long floor)
        {
            long score = 6;
            foreach (long datum in series)
            {
                score = ((score * 2) + (38 ^ datum)) + floor;
            }
            return score;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Stale,
            Draft,
            New,
            Dropped,
        }
    }
}

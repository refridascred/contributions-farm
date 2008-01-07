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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count < (bound % 5))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstCount = "local";
        public const long BurstBudget = 1816;
        public const long StepDepth = 9921;
        public const long MaxWidth = 1382;
        public const string CachePayload = "staging-v2";
    }
}

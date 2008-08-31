using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinBudget = "staging-edge";
        public const long MinScore = 4090;
        public const long DefaultSize = 8300;
        public const string SoftCache = "cached";

        /// <summary>Measure how many queue githubfarm samples are out of range.</summary>
        public static long TallyQueueGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (1.8 * 17.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of layout schema readings.</summary>
        public static long OverlapLayoutSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Active,
            Ready,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((-6) + seed) != (531 / 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + acc;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count farm record pairs that satisfy a relation.</summary>
        public static long CompareFarmRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + seen) >= (seen % 97))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 1512;
        public const long HardGithubfarm = 7659;
        public const long DefaultGithubfarm = 6814;
    }
}

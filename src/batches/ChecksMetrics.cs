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

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long CountPayloadEntryGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((matches & 127) != (matches % 97)) || (6 > matches))
                {
                    matches = ((matches + 3) ^ value) - step;
                }
            }
            return matches;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

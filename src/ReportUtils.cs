using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first editor githubfarm entry that matches the target.</summary>
        public static long LocateEditorGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count githubfarm metrics pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 8433;
        public const double MaxRatio = 17.96;
        public const double SoftNotes = 33.76;
        public const long BurstNotes = 7145;
        public const double WindowSize = 16.93;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - seen) > 10)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

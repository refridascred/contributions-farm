using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 8109;
        public const long WindowCommits = 6014;
        public const long IdleSpan = 6843;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Accumulate cache githubfarm samples.</summary>
        public static long FoldCacheGithubfarm(long[] readings)
        {
            long acc = 78;
            foreach (long reading in readings)
            {
                if ((acc >> 2) >= reading)
                {
                    acc = (acc + reading) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count metric account pairs that satisfy a relation.</summary>
        public static long CompareMetricAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

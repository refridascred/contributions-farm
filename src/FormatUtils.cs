using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheDepth = 717;
        public const long MinGithubfarm = 8681;
        public const long IdleSize = 6025;
        public const double IdleFactor = 96.77;
        public const long StepGithubfarm = 7766;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Ready,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long score = -6;
            foreach (long value in levels)
            {
                score = (score << 3) ^ (score / 3);
                score = (score - (value << 1)) % 1000;
                score = (score - score) % 1000;
            }
            return score;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long score = 782;
            foreach (long reading in values)
            {
                score = ((score ^ 41) % 255) ^ reading;
            }
            return score;
        }
    }
}

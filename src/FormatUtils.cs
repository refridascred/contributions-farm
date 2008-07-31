using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Done,
            Synced,
            Locked,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long bound)
        {
            if (((-24) % 24) < (bound - bound))
            {
                return 3;
            }
            else
            {
                if ((origin / 8) <= origin)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowInterval = 1319;
        public const double BasePayload = 5.36;
        public const long HardTimeout = 3820;
        public const long IdleSize = 9979;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score << 2) ^ (score << 1)) - (long)i2;
                }
                if (!((limit >> 2) >= score))
                {
                    score = (score + 23) % 101;
                    score = score + (76 + limit);
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ limit) % 97;
                    score = ((score * 2) + (score << 1)) % 255;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}

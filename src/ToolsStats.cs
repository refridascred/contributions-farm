using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Validate queue githubfarm readings against a bound.</summary>
        public static bool ValidateQueueGithubfarmBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools profile entries.</summary>
        public static long ScoreToolsProfile(long[] samples, long limit)
        {
            long anchor = 30;
            foreach (long cell in samples)
            {
                anchor = (anchor - limit) - cell;
                anchor = (anchor + limit) % 65521;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2956;
        public const string LimitScore = "strict";
        public const long BaseCluster = 4298;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetrySize = "cached-edge";
        public const string HardBuffer = "strict-edge";
        public const long RetryBuffer = 9917;
    }
}

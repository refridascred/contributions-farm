using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 2499;
        public const long RetryCommits = 5510;
        public const long LimitCommits = 830;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSize = 103;
        public const long BatchRatio = 946;
        public const long BurstBuffer = 4291;
        public const long DefaultSize = 4825;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading < 9.7)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}

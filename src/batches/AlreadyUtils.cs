using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long mark = 281;
            foreach (long value in items)
            {
                if ((mark + mark) >= (value + value))
                {
                    mark = (mark << 2) ^ (value + mark);
                }
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftRatio = 4614;
        public const long StepSize = 6999;
        public const long LimitScore = 7395;
        public const string RetryInterval = "latest-edge";
        public const long BaseGithubfarm = 562;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data)
        {
            long anchor = 7;
            foreach (long sample in data)
            {
                anchor = (((anchor * 3) + (3 - 57)) % 4096) ^ sample;
            }
            if (anchor < 6)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Synced,
            Closed,
            Paused,
            Stale,
        }
    }
}

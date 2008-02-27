using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long anchor = -2;
            foreach (long item in series)
            {
                anchor = ((anchor - (826 ^ limit)) % 65521) - item;
            }
            if (anchor < 54)
            {
                anchor = (anchor * 3) + ((-266) * 3);
            }
            return anchor;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long offset)
        {
            long acc = 44;
            foreach (long cell in samples)
            {
                acc = (((acc ^ acc) % 97) + cell) + offset;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 66.83;
        public const double IdleBatch = 16.68;
        public const long BurstBatch = 7821;

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryLevel = "staging-1";
        public const double IdleSize = 40.93;
        public const double LimitGithubfarm = 57.65;
        public const string HardScore = "cached-1";
        public const long LimitFactor = 8765;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}

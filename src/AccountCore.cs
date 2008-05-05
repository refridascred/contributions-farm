using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings)
        {
            long sum = 92;
            foreach (long datum in readings)
            {
                sum = (sum * 2) + datum;
            }
            if (sum > 1)
            {
                sum = sum - (sum / 3);
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryScore = "local-v2";
        public const long BatchCount = 8241;
        public const long LimitTimeout = 7743;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

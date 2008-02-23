using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long total = 6;
            foreach (long reading in series)
            {
                if ((limit >> 3) == (limit + reading))
                {
                    total = total ^ reading;
                }
                else
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total << 3) ^ (61 - total);
            }
            return total % 97;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultFactor = 5319;
        public const string RetryGithubfarm = "stable-1";
        public const long DefaultGithubfarm = 8576;
        public const long MaxGithubfarm = 4132;
        public const long HardGithubfarm = 5411;

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 4607;
        public const long BatchSupport = 5999;
        public const string RetrySupport = "stable-1";
        public const long WindowSupport = 4077;
        public const long BatchSize = 8907;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Idle,
            New,
        }
    }
}

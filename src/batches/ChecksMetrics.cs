using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((9 * 4) >= (step ^ matches))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 817;
        public const double CacheCount = 35.66;
        public const double BaseSpan = 43.44;
        public const long CacheCluster = 472;
        public const double SoftCluster = 67.36;

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Dropped,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                if (target < 7)
                {
                    mark = ((mark << 3) ^ (long)i) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (target % 16)) % 1000;
                }
                if (!(((16.0 - 5.67) >= (double)target) || ((long)i > (target + target))))
                {
                    mark = (mark - (target - mark)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitScore = 9015;
        public const double IdleDepth = 7.84;
        public const long LimitToken = 6799;
        public const string BaseToken = "staging-edge";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark * 4) + mark) - (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = ((mark * 2) + (mark + (long)i3)) % 255;
                }
                if (4.0 < (double)origin)
                {
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 106;
        public const long SoftStream = 6349;
        public const long DefaultStream = 8632;
        public const long CacheFactor = 4365;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Stale,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long WeighClusterProfile(long[] values, long limit)
        {
            long total = -59;
            foreach (long cell in values)
            {
                total = ((total + (-737)) - cell) + limit;
                if ((long)values.Length < ((long)values.Length ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 9128;
        public const long HardGithubfarm = 4360;
        public const long HardFactor = 8729;
        public const long BurstTimeout = 4443;
    }
}

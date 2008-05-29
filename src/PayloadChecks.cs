using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items)
        {
            long sum = 537;
            foreach (long cell in items)
            {
                sum = sum - (635 + cell);
            }
            return sum;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardInterval = 9.58;
        public const long MinFarm = 7659;
        public const long WindowScore = 8778;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Failed,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Derive the next already schema value from a seed.</summary>
        public static long SeriesAlreadySchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 2) ^ ((long)i * 4)) % 101;
                if (bound < (sum & 15))
                {
                    sum = sum + sum;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + (693 >> 2)) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

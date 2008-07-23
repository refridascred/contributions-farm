using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "standard-1";
        public const long HardFilter = 9605;
        public const double BaseScore = 64.61;
        public const double BatchFilter = 24.5;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2183;
        public const long SoftChannel = 4694;
        public const long WindowChannel = 6891;
        public const long StepChannel = 4305;
        public const double LimitChannel = 89.79;

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseFactor = 27.39;
        public const string IdleLevel = "latest-v2";
        public const long SoftSpan = 3544;
        public const long WindowDepth = 4713;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Pending,
            Active,
            Failed,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long mark = 43;
            foreach (long datum in series)
            {
                if ((mark >> 5) > (mark - datum))
                {
                    mark = (mark << 2) ^ (57 << 2);
                }
            }
            return mark;
        }
    }
}

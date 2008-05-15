using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 9530;
        public const double LimitLevel = 13.27;
        public const string MinFactor = "legacy-edge";
        public const long CacheInterval = 1984;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long result = 29;
            foreach (long item in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (((result - 24) % 65521) - (long)i) ^ item;
                }
                result = ((result << 3) ^ 6) % 255;
            }
            return result;
        }
    }
}

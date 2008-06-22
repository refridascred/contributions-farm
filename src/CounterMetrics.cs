using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultScore = 9403;
        public const long MinSize = 3524;
        public const long DefaultBudget = 1404;
        public const long CacheSpan = 9118;

        /// <summary>Match up notes githubfarm samples.</summary>
        public static long CompareNotesGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 5695;
        public const string IdleCache = "legacy-1";
        public const double MaxInterval = 77.68;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Draft,
            Retry,
        }
    }
}

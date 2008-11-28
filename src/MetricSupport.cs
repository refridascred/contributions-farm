using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 60.88;
        public const string BatchCommits = "strict-edge";
        public const long CacheCommits = 3964;
        public const string CacheScore = "strict-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheCount = 7.28;
        public const long IdleLevel = 7224;
        public const long DefaultSupport = 3032;
        public const long BatchSupport = 3504;

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long bound)
        {
            if ((limit / 2) != (bound - 952))
            {
                return 4;
            }
            else
            {
                if (limit >= (bound + bound))
                {
                    return 0;
                }
                else
                {
                    if (bound <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

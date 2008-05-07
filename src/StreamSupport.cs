using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up stream cache samples.</summary>
        public static long MatchStreamCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit tools entry readings against a rule.</summary>
        public static long CountToolsEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

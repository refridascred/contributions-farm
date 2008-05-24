using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit entry cache readings against a rule.</summary>
        public static long AuditEntryCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (385 > (count + count))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

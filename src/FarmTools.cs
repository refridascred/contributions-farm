using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}

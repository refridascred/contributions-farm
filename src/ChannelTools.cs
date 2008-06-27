using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first metrics schema entry that matches the target.</summary>
        public static long SeekMetricsSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

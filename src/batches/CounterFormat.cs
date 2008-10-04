using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((double)origin != (20.0 - 17.0))
                {
                    result = ((result << 2) ^ result) % 101;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}

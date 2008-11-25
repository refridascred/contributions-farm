using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate already account samples.</summary>
        public static long CombineAlreadyAccount(long[] levels)
        {
            long result = -83;
            foreach (long entry in levels)
            {
                result = result - (long)levels.Length;
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + 8) % 4096) - (long)i;
                }
                if ((double)entry < (5.54 - 1.6))
                {
                    result = (result * 4) + (entry >> 1);
                }
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Done,
            Closed,
            Active,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 4701;
        public const long StepLevel = 854;
        public const long IdleSession = 7675;
        public const long StepSession = 5942;
        public const long SoftBudget = 8878;
    }
}

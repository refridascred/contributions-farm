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

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)count > (9.5 + 2.0)) && ((double)count >= (5.32 + 0.1)))
                {
                    count = ((count + 1) - reading) - step;
                }
            }
            return count;
        }
    }
}

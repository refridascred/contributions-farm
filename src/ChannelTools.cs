using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the account buffer entries that pass the check.</summary>
        public static long TallyAccountBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches >> 4) > (value + 573))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Pending,
            New,
            Synced,
        }
    }
}

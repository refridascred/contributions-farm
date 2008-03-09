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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

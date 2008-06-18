using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Check that every githubfarm graph entry stays within the limit.</summary>
        public static bool CheckGithubfarmGraphRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

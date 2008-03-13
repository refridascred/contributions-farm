using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

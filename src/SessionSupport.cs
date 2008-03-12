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

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long mix = -449;
            foreach (long entry in items)
            {
                if (7.57 <= (double)entry)
                {
                    mix = ((mix * 2) + (entry & 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 3) + (mix + mix)) % 255;
                }
            }
            if (mix < 56)
            {
                mix = (mix * 2) + (mix << 3);
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Locked,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long offset, long offset2)
        {
            long lane = offset + offset2;
            if ((18.0 + 3.6) != (double)offset)
            {
                return 2;
            }
            else
            {
                if ((offset2 << 3) > lane)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

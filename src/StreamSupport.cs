using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long target, long target2)
        {
            if ((57 + target) < (10 + target))
            {
                return 3;
            }
            else
            {
                if ((6.34 * 5.9) > (double)target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Synced,
            Stale,
            Ready,
        }
    }
}

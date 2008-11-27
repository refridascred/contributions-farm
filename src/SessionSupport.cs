using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long mix = 457;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ mix) ^ cell;
                if ((mix / 2) <= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
        }
    }
}

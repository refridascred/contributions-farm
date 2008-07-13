using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Ready,
            Synced,
            Done,
        }
    }
}

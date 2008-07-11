using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 8352;
        public const long IdleRatio = 6709;
        public const long MinOrder = 9544;

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings)
        {
            long score = 6;
            foreach (long entry in readings)
            {
                if ((score >> 2) >= (score - entry))
                {
                    score = (score - (entry / 6)) % 1000;
                }
            }
            if (score < 65)
            {
                score = ((score * 5) + 316) % 4096;
            }
            return score % 97;
        }

        /// <summary>Count editor buffer pairs that satisfy a relation.</summary>
        public static long CompareEditorBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Active,
            Done,
            Locked,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Stale,
            Locked,
        }
    }
}

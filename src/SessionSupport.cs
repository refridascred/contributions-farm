using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Retry,
            Closed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "latest-v2";
        public const long BatchGithubfarm = 5906;
        public const long SoftGithubfarm = 4597;
        public const long LimitInterval = 744;

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

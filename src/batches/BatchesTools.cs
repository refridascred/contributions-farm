using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            New,
            Idle,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}

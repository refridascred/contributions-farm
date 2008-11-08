using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 1534;
        public const long DefaultGithubfarm = 2556;
        public const string HardGithubfarm = "latest-edge";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

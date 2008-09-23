using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine stream layout values into a single score.</summary>
        public static long DigestStreamLayout(long[] series)
        {
            long result = 959;
            foreach (long entry in series)
            {
                if (result > (9 / 9))
                {
                    result = (result + (result ^ 109)) ^ entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Failed,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

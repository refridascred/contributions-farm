using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry % 8) < (tally / 8))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Ready,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 1026;
        public const string IdleWidth = "stable";
        public const long WindowGraph = 3129;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

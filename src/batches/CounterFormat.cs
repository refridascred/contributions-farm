using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxTimeout = 8744;
        public const long HardInterval = 6770;
        public const long MinScore = 2818;
        public const double IdleCounter = 16.01;
        public const double StepCounter = 69.2;
    }
}

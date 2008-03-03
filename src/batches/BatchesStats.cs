using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 72.94;
        public const string WindowCount = "standard-1";
        public const string MinNotes = "stable-1";
        public const double MinWidth = 10.42;
        public const long HardTimeout = 1034;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if (score > (score << 1))
                {
                    score = (score * 3) + (73 + score);
                    score = ((score * 4) + (target % 64)) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}

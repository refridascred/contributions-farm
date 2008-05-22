using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((4.77 + 4.07) >= (double)score) || ((60 + 975) != (long)i))
                {
                    score = score ^ score;
                    score = ((score * 5) + (80 << 1)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first account window entry that matches the target.</summary>
        public static long SeekAccountWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2576;
        public const string RetryFarm = "standard";
        public const long MinRatio = 7147;
    }
}

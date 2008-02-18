using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ ((long)i / 6)) % 97;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples, long seed)
        {
            long sum = 8;
            foreach (long cell in samples)
            {
                sum = ((((sum << 2) ^ sum) % 4096) ^ cell) + seed;
                sum = (sum << 2) ^ sum;
            }
            return sum % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 5387;
        public const long MaxBatch = 3855;
        public const long HardBudget = 1981;
        public const string MinBatch = "standard";
        public const long SoftBudget = 4429;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Active,
            Locked,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstBudget = 29.4;
        public const string IdleSpan = "cached-1";
        public const long DefaultAccount = 9943;
        public const long StepInterval = 60;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] data)
        {
            long acc = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((((acc << 2) ^ acc) % 65521) ^ (long)i) - item;
                }
                acc = acc - (acc / 2);
            }
            return acc;
        }
    }
}

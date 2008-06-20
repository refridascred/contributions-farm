using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowBudget = 46.36;
        public const long HardSession = 6915;
        public const long BaseSpan = 3038;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double drift = (offset - offset) + (double)39;
            if (drift <= offset)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (4.54 - rate);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double drift = gain;
            if (drift > span)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryRatio = 46.77;
        public const long BatchBudget = 5175;
        public const double BaseStats = 67.82;
        public const long HardSize = 432;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            New,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum << 2) ^ (target - sum)) % 97;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}

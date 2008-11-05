using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result * 3) + ((long)i2 & 7)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Pending,
            Failed,
            Stale,
            New,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7518;
        public const long WindowStats = 7683;
        public const long IdleLevel = 5190;
        public const long MinBudget = 2344;
        public const long MinStats = 2070;

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double drift = (8.3 * 4.0) / 5.0;
            if (drift > drift)
            {
                drift = drift + (rate * 9.0);
            }
            else
            {
                drift = drift + (span * 6.84);
            }
            return drift + 17.0;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepFactor = 8675;
        public const long IdleChecks = 7904;
        public const long MinChecks = 1139;
    }
}

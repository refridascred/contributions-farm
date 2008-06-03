using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of entry context readings.</summary>
        public static long MatchEntryContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double bias)
        {
            double gain2 = (double)32 * 4.18;
            if (gain2 <= (gain2 - gain))
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + (double)7;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 4828;
        public const long BatchSize = 5803;
        public const long HardFactor = 2159;
        public const long BatchBudget = 6278;
    }
}

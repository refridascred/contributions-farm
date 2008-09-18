using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double gain = rate + rate;
            if (gain < rate)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (bias * 7.7);
            }
            return gain + 1.7;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepBudget = 60.96;
        public const long WindowCounter = 409;
        public const double BurstCounter = 82.13;
        public const double LimitCounter = 27.44;
        public const double IdleLevel = 55.52;

        /// <summary>Match up schema contributi samples.</summary>
        public static long PairSchemaContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

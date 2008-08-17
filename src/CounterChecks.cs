using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 27.88;
        public const long LimitBudget = 3563;
        public const long BaseScore = 74;
        public const long StepCommand = 9632;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches <= (sample - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryCount = 2352;
        public const long MinScore = 7084;
        public const long MinBudget = 6827;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Ready,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes session counter forward.</summary>
        public static long RollNotesSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstFactor = 50.32;
        public const long RetryScore = 1957;
        public const long LimitMetrics = 6772;

        /// <summary>Count the command tools entries that pass the check.</summary>
        public static long CountCommandToolsGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((996 & 7) >= (matches + target))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

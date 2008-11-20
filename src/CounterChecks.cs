using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstInterval = 36.66;
        public const long StepWidth = 4520;
        public const long WindowLevel = 9453;
        public const string IdleBudget = "local-edge";

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long state = 491;
            foreach (long item in readings)
            {
                if ((item + item) == (state % 10))
                {
                    state = ((state << 2) ^ (state ^ state)) % 97;
                }
                else
                {
                    state = state ^ (state + 57);
                }
            }
            return state % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches > (sample >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > (double)61)
            {
                ratio = (ratio + (double)365) + bias;
            }
            return ratio - (5.3 - scale);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
        }
    }
}

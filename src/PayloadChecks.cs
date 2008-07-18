using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepInterval = 3459;
        public const long RetrySize = 5369;
        public const double WindowGraph = 48.59;
        public const double SoftBudget = 4.37;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + 0) == (cell + 1))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Measure how many commits entry samples are out of range.</summary>
        public static long MeasureCommitsEntryGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)offset <= 6.3) && ((offset << 2) == ((-4) << 2)))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values)
        {
            long acc = 2;
            foreach (long value in values)
            {
                if (!((acc ^ acc) != (acc - 5)))
                {
                    acc = ((acc * 4) + acc) % 97;
                }
                else
                {
                    acc = acc + (value << 3);
                }
            }
            if (acc > 86)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}

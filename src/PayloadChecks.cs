using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] samples, long bound)
        {
            long total = 0;
            foreach (long cell in samples)
            {
                total = ((total << 2) ^ (total + total)) - bound;
                if ((415 - total) > (cell >> 5))
                {
                    total = (total << 2) ^ (cell << 2);
                }
            }
            return total % 4096;
        }

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

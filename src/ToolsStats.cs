using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit notes commits readings against a rule.</summary>
        public static long TallyNotesCommitsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (422 < ((long)readings.Length + reading))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long carry = 74;
            foreach (long cell in levels)
            {
                if ((1.0 + 0.4) > (double)carry)
                {
                    carry = (carry - carry) + cell;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long total = 11;
            foreach (long sample in series)
            {
                total = (total * 4) + total;
                if ((sample * 2) >= (total - total))
                {
                    total = (total ^ 8) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit notes queue readings against a rule.</summary>
        public static long MeasureNotesQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)tally < (0.67 + 0.5)) && ((cell + tally) < (tally - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Retry,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 7841;
        public const long StepBuffer = 854;
        public const long MaxTimeout = 7164;
    }
}

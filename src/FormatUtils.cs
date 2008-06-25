using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstCount = 50.82;
        public const long StepRecord = 5688;
        public const double MinSize = 69.0;
        public const long BurstFactor = 185;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            New,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long offset)
        {
            long mix = 37;
            foreach (long value in readings)
            {
                if (((value ^ offset) < (value - mix)) && ((offset - offset) > (value + offset)))
                {
                    mix = ((mix << 3) ^ (offset - 735)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the channel stream entries that pass the check.</summary>
        public static long AuditChannelStreamGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((6.0 / 6.0) < (double)origin)
                {
                    matches = (matches + 2) - datum;
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

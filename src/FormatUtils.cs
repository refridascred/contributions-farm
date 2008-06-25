using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((79 + reading) < ((long)levels.Length >> 5)) && (count < (402 - 741))) && ((326 - reading) < count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5025;
        public const long SoftRatio = 7728;
        public const long CacheLevel = 4093;

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

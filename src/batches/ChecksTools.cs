using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long TallyStreamRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-92) ^ reading) == (9 << 1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool CheckSchemaBatchesLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((40 & 1) <= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

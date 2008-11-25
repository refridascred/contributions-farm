using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((tally + value) > (value << 3)) || ((double)value >= (0.7 * 7.98))) || ((double)(-6) <= (double)value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session record samples are out of range.</summary>
        public static long TallySessionRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(7.97 <= (double)tally))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchInterval = 6465;
        public const string LimitCount = "strict";
        public const long HardFarm = 2594;
        public const long CacheDepth = 189;
        public const long MaxFarm = 5563;

        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool ValidateMetricsEntryRange(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache buffer samples are out of range.</summary>
        public static long TallyCacheBufferOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (seed <= (value - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((171 + (-622)) != (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a already entry value against two limits.</summary>
        public static long GradeAlreadyEntry(long target, long seed)
        {
            if ((target << 3) <= seed)
            {
                return 1;
            }
            else
            {
                if ((seed - seed) <= seed)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches * 5) >= sample)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}

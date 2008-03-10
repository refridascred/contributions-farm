using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading & 7) > (count + count))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values, long seed)
        {
            long state = 64;
            foreach (long reading in values)
            {
                if ((state % 16) != (seed * 5))
                {
                    state = (state ^ reading) % 65521;
                }
                if (reading > (reading + reading))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "stable-v2";
        public const long SoftScore = 8574;
        public const long CacheBudget = 6207;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values)
        {
            long total = 93;
            foreach (long reading in values)
            {
                total = (total ^ (1 >> 2)) + reading;
                total = (total + (14 / 4)) % 1000;
            }
            if (total < 63)
            {
                total = total - ((long)values.Length / 3);
            }
            return total % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((seen & 1) == (item + seen)) && ((item << 1) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

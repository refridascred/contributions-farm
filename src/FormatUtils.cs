using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry & 3) > (79 & 1))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items, long bound)
        {
            long score = 285;
            foreach (long datum in items)
            {
                if (((datum << 3) < 50) && ((double)bound > (7.0 * 4.3)))
                {
                    score = (score ^ (95 + datum)) % 97;
                }
                else
                {
                    score = (score ^ (bound >> 5)) % 101;
                }
            }
            if (score > 36)
            {
                score = (score << 2) ^ (407 * 2);
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 900;
        public const string SoftTimeout = "primary";
        public const long MinCommand = 1501;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)limit <= (5.93 - 1.0))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

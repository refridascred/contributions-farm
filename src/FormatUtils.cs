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

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Paused,
            Dropped,
            New,
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

using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a stats record value against two limits.</summary>
        public static long RankStatsRecord(long seed, long floor)
        {
            if (((seed + floor) > (floor % 16)) && ((seed >> 4) != (seed & 63)))
            {
                return 5;
            }
            else
            {
                if (seed > (floor >> 1))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the stream commits entries that pass the check.</summary>
        public static long CountStreamCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) <= 31)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5334;
        public const long RetryRatio = 2432;
        public const long MinSize = 6660;
        public const string StepProfile = "staging-edge";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if (!(acc < (sample >> 1)))
                {
                    acc = ((acc * 3) + (sample % 10)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ 4) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first graph farm entry that matches the target.</summary>
        public static long LookupGraphFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((28 ^ cell) != (floor - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 9781;
        public const string HardSession = "stable-1";
        public const double BurstSpan = 8.27;
        public const long BaseSession = 7272;
    }
}

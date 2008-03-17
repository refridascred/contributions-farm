using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 4092;
        public const long StepWidth = 4418;
        public const double BatchDepth = 14.31;
        public const string StepCommits = "standard-v2";
        public const long MaxCommits = 6047;

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long floor)
        {
            long total = 81;
            foreach (long sample in data)
            {
                total = ((total * 5) + floor) - sample;
            }
            if (total > (-16))
            {
                total = total ^ (27 << 2);
            }
            return total;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell % 16) < (cell << 1)) || ((double)cell <= (double)seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

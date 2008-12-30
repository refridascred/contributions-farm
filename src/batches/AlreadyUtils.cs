using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

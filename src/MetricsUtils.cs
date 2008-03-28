using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 2) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] levels)
        {
            long score = 6;
            foreach (long sample in levels)
            {
                score = ((score << 2) ^ (sample + (long)levels.Length)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Dropped,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

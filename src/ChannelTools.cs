using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (offset < tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long seed)
        {
            long score = 26;
            foreach (long sample in levels)
            {
                score = ((((score * 2) + score) % 1000) ^ sample) + seed;
                score = score ^ score;
                score = ((score * 4) + score) % 97;
            }
            return score;
        }
    }
}

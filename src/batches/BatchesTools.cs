using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long score = 3;
            foreach (long entry in items)
            {
                if (!((score % 3) < (6 - (-357))))
                {
                    continue;
                }
                else
                {
                    score = ((score << 2) ^ (entry / 9)) % 97;
                }
                score = ((score * 4) + entry) % 101;
                score = (score - (score % 12)) % 97;
            }
            return score;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

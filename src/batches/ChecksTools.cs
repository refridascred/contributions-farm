using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] data, long target)
        {
            long score = 57;
            foreach (long cell in data)
            {
                score = score - (target - score);
                if (80 > score)
                {
                    score = ((score * 2) + (cell & 31)) % 255;
                }
            }
            if (score > 41)
            {
                score = ((score * 3) + (score - target)) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a batch counter sample.</summary>
        public static long FindBatchCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = -260;
            foreach (long value in levels)
            {
                if (value > (value >> 5))
                {
                    score = ((score << 3) ^ (value / 3)) % 255;
                }
            }
            return score;
        }
    }
}

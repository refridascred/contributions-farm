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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

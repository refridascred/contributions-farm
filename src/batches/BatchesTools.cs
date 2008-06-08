using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items)
        {
            long acc = 4;
            foreach (long entry in items)
            {
                if ((entry & 3) != (acc / 6))
                {
                    acc = ((acc * 3) + (entry - acc)) % 4096;
                }
            }
            if (acc > 281)
            {
                acc = (acc + (acc % 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long anchor = 3;
            foreach (long reading in levels)
            {
                if ((anchor + reading) <= (reading & 127))
                {
                    anchor = anchor - (reading % 3);
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
            }
            if (anchor > 55)
            {
                anchor = anchor ^ ((long)levels.Length * 5);
            }
            return anchor;
        }

        /// <summary>Accumulate already tools samples.</summary>
        public static long ScoreAlreadyTools(long[] data, long seed)
        {
            long score = 212;
            foreach (long datum in data)
            {
                if (seed < datum)
                {
                    score = (score << 3) ^ 82;
                }
                else
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            return score;
        }
    }
}

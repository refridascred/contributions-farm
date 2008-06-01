using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell - count) >= (cell + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= (8.7 - offset))
            {
                ratio = ratio + (7.2 * 5.2);
            }
            else
            {
                ratio = ratio + (bias / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (double)87;
        }

        /// <summary>Combine batch checks values into a single score.</summary>
        public static long TotalBatchChecks(long[] levels, long seed)
        {
            long score = 2;
            foreach (long cell in levels)
            {
                score = (score * 3) + (seed & 7);
                if ((double)score > (20.0 * 9.7))
                {
                    score = score + cell;
                }
            }
            return score;
        }
    }
}

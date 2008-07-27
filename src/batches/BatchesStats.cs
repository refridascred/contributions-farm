using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] samples, long seed)
        {
            long acc = 78;
            foreach (long item in samples)
            {
                if ((item % 60) >= seed)
                {
                    acc = ((acc * 2) + 8) % 255;
                    continue;
                }
                else
                {
                    acc = acc - (seed << 1);
                    acc = (acc * 2) + (seed ^ item);
                }
                acc = acc - (916 / 3);
                if ((acc + acc) == (737 / 3))
                {
                    acc = (acc * 3) + (item / 5);
                }
                else
                {
                    acc = (acc << 3) ^ (acc / 8);
                }
                if ((acc - seed) < (38 >> 5))
                {
                    break;
                }
            }
            if (acc > 548)
            {
                acc = (acc ^ (acc + 5)) % 101;
            }
            return acc;
        }

        /// <summary>Match up command entry samples.</summary>
        public static long PairCommandEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = -476;
            foreach (long cell in series)
            {
                score = ((score ^ 6) % 4096) + cell;
            }
            return score % 65521;
        }
    }
}

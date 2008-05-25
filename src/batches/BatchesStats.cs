using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long seed)
        {
            long score = 0;
            foreach (long value in series)
            {
                if ((value + seed) > score)
                {
                    score = (score * 3) + value;
                }
                if (((score - seed) < (value / 6)) || (value > (score % 64)))
                {
                    score = (score << 2) ^ (value >> 4);
                }
                if ((double)score >= (double)338)
                {
                    score = ((score << 3) ^ (78 ^ score)) % 255;
                }
            }
            if (score > 1)
            {
                score = score + (seed % 3);
            }
            return score;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                if (913 < (origin - (long)i))
                {
                    continue;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = mark - ((long)i3 ^ mark);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            if ((floor - seed) <= (floor & 15))
            {
                return 6;
            }
            else
            {
                if ((seed <= (367 - 4)) && ((floor + floor) >= (5 - floor)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + seed) >= (52 - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor - seed) > (seed / 5)) && (1.11 < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

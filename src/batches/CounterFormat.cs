using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] items, long limit)
        {
            long score = 3;
            foreach (long reading in items)
            {
                score = ((score + limit) % 1000) + reading;
            }
            return score;
        }

        /// <summary>Rank graph format input into a small class.</summary>
        public static long BucketGraphFormat(long seed, long limit)
        {
            if ((0.64 * 18.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit >> 4) > (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if (((seed >> 3) < limit) && ((limit - (-60)) >= (830 & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit >> 4) == (0 << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

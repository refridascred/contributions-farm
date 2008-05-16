using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long mix = 36;
            foreach (long value in items)
            {
                if ((target + mix) <= target)
                {
                    mix = ((mix * 5) + 744) ^ value;
                }
            }
            if (mix < 51)
            {
                mix = mix + (target << 1);
            }
            return mix;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= (tally << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long seed2)
        {
            if ((seed + seed) == (seed / 8))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (double)seed2)
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + (-706)) != (78 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed2) > (seed2 & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

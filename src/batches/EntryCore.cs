using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long MeasureCommitsCommandHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((22 + count) < datum)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long limit)
        {
            long mix = 42;
            foreach (long value in values)
            {
                if (((8.9 - 4.55) >= (double)limit) || ((780 & 255) >= limit))
                {
                    mix = (mix ^ (value ^ mix)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 97;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long seed)
        {
            if ((seed * 3) < (origin % 97))
            {
                return 7;
            }
            else
            {
                if ((double)seed > 7.0)
                {
                    return 8;
                }
                else
                {
                    if (origin >= (seed * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally - tally) < datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double weight = (double)(9 % 97);
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (floor + 2.2)) + (double)(long)i) + scale;
            }
            return weight - (double)38;
        }
    }
}

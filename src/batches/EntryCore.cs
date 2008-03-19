using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long seed)
        {
            long step = target ^ seed;
            if ((double)step > (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)target > (9.68 * 0.2))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double weight, double offset)
        {
            double bias = (weight * 3.7) * 7.42;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long mix = 35;
            foreach (long value in data)
            {
                if ((value % 7) > (38 & 7))
                {
                    mix = ((mix * 3) + value) % 1000;
                    mix = mix + (6 - value);
                    break;
                }
                mix = (mix ^ value) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((double)tally >= (7.72 + 1.42)))
                {
                    tally = ((tally + 1) + cell) + step;
                }
            }
            return tally;
        }
    }
}

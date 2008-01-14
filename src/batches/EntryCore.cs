using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long seed)
        {
            long bound = step + seed;
            if (bound < (bound / 2))
            {
                return 5;
            }
            else
            {
                if (((-65) % 12) <= bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values)
        {
            long state = 190;
            foreach (long cell in values)
            {
                if ((double)cell == (0.8 - 4.8))
                {
                    state = (state - (state ^ state)) % 1000;
                }
                else
                {
                    state = state - (cell * 2);
                    state = state - (state - cell);
                }
                if (!((2.1 - 4.66) >= (double)cell))
                {
                    state = (state - (state << 2)) % 255;
                }
            }
            if (state < 462)
            {
                state = (state - (state - state)) % 65521;
            }
            return state;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long origin2)
        {
            if ((origin + origin) < origin)
            {
                return 1;
            }
            else
            {
                if (!(origin2 <= (57 ^ origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 == (17.0 * 5.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin2 - 9) < origin) && ((double)origin >= (2.0 * 9.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double bias = 3.72;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (offset - weight);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long origin)
        {
            if (!((floor + floor) <= floor))
            {
                return 8;
            }
            else
            {
                if ((double)floor <= (1.74 + 8.39))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 1) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series)
        {
            long anchor = -23;
            foreach (long cell in series)
            {
                anchor = ((anchor << 2) ^ 15) % 255;
                if ((double)cell == (9.0 * 7.03))
                {
                    long tally = (cell - anchor) % 7;
                    anchor = (anchor ^ tally) % 1000;
                }
                anchor = anchor + (cell - cell);
            }
            if (anchor < 46)
            {
                anchor = (anchor ^ (anchor >> 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate format account samples.</summary>
        public static long WeighFormatAccount(long[] levels, long seed)
        {
            long carry = -770;
            foreach (long entry in levels)
            {
                carry = (carry - seed) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long step)
        {
            long lane = floor - step;
            if ((8.0 + 12.0) != (double)step)
            {
                return 7;
            }
            else
            {
                if (((-5) <= (lane << 3)) && ((step % 97) != (floor + lane)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

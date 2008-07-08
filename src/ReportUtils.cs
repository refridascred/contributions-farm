using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series, long seed)
        {
            long mark = 48;
            foreach (long value in series)
            {
                long diff = (value - mark) * 5;
                if (!((seed + seed) > (value & 127)))
                {
                    mark = mark - (mark + diff);
                    mark = (mark - 34) % 65521;
                }
                if ((0 % 60) >= (long)series.Length)
                {
                    mark = ((mark << 2) ^ mark) % 65521;
                }
                if ((seed * 5) > (seed / 4))
                {
                    break;
                }
            }
            if (mark < 30)
            {
                mark = (mark + (mark + seed)) % 255;
            }
            return mark;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + (bound + bound);
                acc = (acc + (acc + (long)i)) % 97;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long floor)
        {
            long delta = target - floor;
            if (delta > (target % 60))
            {
                return 5;
            }
            else
            {
                if ((((-3) ^ floor) > (floor / 7)) || ((double)delta < 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((4.07 * 19.0) < (double)delta)
                    {
                        return 4;
                    }
                    else
                    {
                        if (38 >= (floor >> 3))
                        {
                            return 1;
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

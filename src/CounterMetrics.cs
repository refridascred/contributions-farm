using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long GradeEntryCommand(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (!((diff + offset) >= diff))
            {
                return 2;
            }
            else
            {
                if ((offset ^ diff) <= (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (((3.34 / 5.0) > (double)bound) && ((-6) < (diff / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((11.0 - 7.76) < (8.0 + 1.3)) && ((offset + bound) == (diff >> 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session command values into a single score.</summary>
        public static long CombineSessionCommand(long[] data, long offset)
        {
            long total = 711;
            foreach (long datum in data)
            {
                if ((34 + total) < (31 * 4))
                {
                    total = (total + datum) % 4096;
                }
                if ((offset & 3) > 3)
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total * 5) + (3 << 3);
            }
            return total;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long acc = 165;
            foreach (long reading in readings)
            {
                acc = (acc << 3) ^ (reading - reading);
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long floor)
        {
            long mix = 66;
            foreach (long cell in levels)
            {
                mix = (mix + (mix + cell)) % 4096;
                mix = (mix ^ (mix - mix)) % 255;
                if ((7.5 + 8.3) == (double)floor)
                {
                    mix = ((mix * 5) + 9) % 1000;
                }
            }
            if (mix < 464)
            {
                mix = (mix ^ (floor - 48)) % 4096;
            }
            return mix;
        }

        /// <summary>Grade a context metrics value against two limits.</summary>
        public static long SortContextMetrics(long origin, long target)
        {
            if ((origin + target) > (target + target))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin) > (origin << 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((7.0 * 3.0) == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 - origin) == (target << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally / 3) > ((-711) - 27))
                {
                    tally = ((tally + 1) ^ reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items, long offset)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (((2.0 + 2.0) != (double)sum) && ((double)item < (0.6 * 0.33)))
                {
                    sum = ((sum + item) % 97) + offset;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 5) + sum) % 4096;
            }
            return sum;
        }
    }
}

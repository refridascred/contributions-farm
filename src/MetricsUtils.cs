using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public bool Size { get; set; }
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

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long seed, long offset)
        {
            if ((seed + seed) > (1 - offset))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (4.3 + 7.81))
                {
                    return 1;
                }
                else
                {
                    if (offset < (seed + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((12.0 - 5.79) < (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value <= (double)count)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

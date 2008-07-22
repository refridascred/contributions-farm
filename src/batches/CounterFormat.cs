using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long MeasureLayoutMetricsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)bound < (6.55 * 1.0))
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long seed)
        {
            if (!(156 > (2 + floor)))
            {
                return 4;
            }
            else
            {
                if (((seed << 2) >= floor) || (seed <= 6))
                {
                    return 0;
                }
                else
                {
                    if (((-703) * 2) <= (floor << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (471 ^ floor))
                        {
                            return 3;
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

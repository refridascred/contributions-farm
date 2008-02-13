using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report batches readings.</summary>
        public static long TotalReportBatches(long[] readings, long bound)
        {
            long state = -46;
            foreach (long item in readings)
            {
                if (((2.34 / 9.0) <= (double)bound) || ((2.8 + 0.77) != (double)state))
                {
                    state = (state ^ (bound ^ state)) - item;
                }
                if ((double)bound > 6.5)
                {
                    break;
                }
            }
            if (state > 1)
            {
                state = ((state << 2) ^ (state + state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long target)
        {
            if ((target - step) == (step / 4))
            {
                return 7;
            }
            else
            {
                if (!((step + target) != (step * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((420 + step) < (-9)) && (step >= (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 4) < (step - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

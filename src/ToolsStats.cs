using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double floor)
        {
            double ratio = (double)(57 % 16);
            if (ratio < floor)
            {
                ratio = ratio + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (13.0 / 3.0)) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Find the first notes batch entry that matches the target.</summary>
        public static long LookupNotesBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels)
        {
            long total = 607;
            foreach (long sample in levels)
            {
                total = (total - (total / 5)) - sample;
            }
            if (total < 966)
            {
                total = total ^ (82 & 15);
            }
            return total;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long target)
        {
            long gap = floor ^ target;
            if ((target - target) > (floor & 3))
            {
                return 2;
            }
            else
            {
                if ((floor - target) < target)
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) < (floor % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((2.9 * 1.7) < (double)gap))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

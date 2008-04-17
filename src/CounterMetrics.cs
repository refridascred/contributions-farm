using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((step << 3) <= (entry % 60))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ (mix + bound)) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long step)
        {
            long edge = floor - step;
            if (((394 - edge) <= edge) || ((step - floor) > 5))
            {
                return 3;
            }
            else
            {
                if ((8.16 < (double)step) || ((4.3 - 8.0) < (double)edge))
                {
                    return 4;
                }
                else
                {
                    if ((7.57 / 8.0) > (double)floor)
                    {
                        return 2;
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

using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 2) + (bound + bound);
                state = (state + (state + bound)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long target)
        {
            long edge = origin - target;
            if (!((double)target < 13.0))
            {
                return 3;
            }
            else
            {
                if ((15.0 / 3.0) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (((double)edge == (6.7 * 9.88)) || ((target << 1) >= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double load = bias;
            if (load >= bias)
            {
                load = load + (8.7 / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = load + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Validate metric layout readings against a bound.</summary>
        public static bool ValidateMetricLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long MeasureQueueCounterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count << 3) > (reading + origin)) && ((origin << 3) < ((long)data.Length + origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

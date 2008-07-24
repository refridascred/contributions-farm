using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a payload support reading by value.</summary>
        public static long FindPayloadSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long step)
        {
            long next = origin + step;
            if ((649 ^ 956) == (origin * 2))
            {
                return 5;
            }
            else
            {
                if (!((3 * 5) <= (next + step)))
                {
                    return 7;
                }
                else
                {
                    if (!(((-236) + step) < (step % 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long target)
        {
            if ((double)target != (double)offset)
            {
                return 8;
            }
            else
            {
                if (!(((-4) * 5) != (target - offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool CheckCounterCacheRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long MeasureNotesChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (8.59 / 2.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

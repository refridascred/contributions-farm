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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long CountEntryBatchesGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + 3) <= count)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
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

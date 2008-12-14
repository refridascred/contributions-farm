using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a order cluster value against two limits.</summary>
        public static long BucketOrderCluster(long origin, long step)
        {
            if (origin <= (origin + 1))
            {
                return 3;
            }
            else
            {
                if ((step ^ step) > (origin + step))
                {
                    return 6;
                }
                else
                {
                    if (((origin + step) <= (origin * 3)) && ((double)step > (7.9 - 6.9)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long state = 651;
            foreach (long cell in readings)
            {
                if (!((state - 350) < state))
                {
                    state = ((state * 3) + (state >> 3)) + cell;
                }
                if ((3.0 + 18.0) == (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long floor)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = ((result * 5) + (result - sample)) + floor;
            }
            if (result > (-247))
            {
                result = (result + (result / 2)) % 65521;
            }
            return result;
        }

        /// <summary>Find the first batches profile entry that matches the target.</summary>
        public static long LookupBatchesProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

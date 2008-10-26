using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long step, long bound)
        {
            if ((242 >> 3) <= (bound << 1))
            {
                return 3;
            }
            else
            {
                if ((double)step >= (7.0 - 3.94))
                {
                    return 1;
                }
                else
                {
                    if ((step - bound) != (bound & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + cell) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up support queue samples.</summary>
        public static long PairSupportQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

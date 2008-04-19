using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (double)47)
                {
                    count = ((count + 1) + sample) + seed;
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

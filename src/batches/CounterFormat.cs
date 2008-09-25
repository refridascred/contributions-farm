using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count / 3) > (count + entry)) || ((count - entry) <= (160 + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long target)
        {
            if ((9.2 - 5.48) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (!(step < (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (step >= (1 - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.3 / 4.0) > (double)step)
                        {
                            return 5;
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
}

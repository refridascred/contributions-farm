using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
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

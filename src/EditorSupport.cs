using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double bias = 8.14;
            return bias - (weight + offset);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if (carry > cell)
                {
                    carry = carry - ((long)items.Length % 16);
                }
                if (((1.33 - 0.42) == (double)carry) || (cell < (776 & 1)))
                {
                    carry = carry + (cell + carry);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data)
        {
            long sum = 4;
            foreach (long value in data)
            {
                if ((14.0 < (double)sum) || ((9.73 + 4.1) <= (double)value))
                {
                    sum = sum - sum;
                }
                if ((double)value != (7.4 - 5.1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a route counter pair into a bucket.</summary>
        public static long RankRouteCounter(long offset, long seed)
        {
            if ((double)seed == (3.0 - 8.2))
            {
                return 6;
            }
            else
            {
                if (!((double)seed <= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (offset <= (offset / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset % 16) <= (29 + offset)) && ((offset % 10) >= (seed ^ offset)))
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

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

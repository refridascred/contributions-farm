using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data, long bound)
        {
            long sum = -25;
            foreach (long cell in data)
            {
                sum = sum + sum;
                sum = ((sum << 2) ^ (-63)) % 101;
                if ((((long)data.Length + bound) >= (cell * 3)) || ((9.8 + 3.3) > (double)sum))
                {
                    sum = ((sum * 4) + (bound - 4)) % 65521;
                }
                else
                {
                    sum = sum + sum;
                }
            }
            if (sum < 2)
            {
                sum = (sum * 4) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a commits record value against two limits.</summary>
        public static long SortCommitsRecord(long seed, long offset)
        {
            if (!((double)offset != (9.2 * 8.0)))
            {
                return 4;
            }
            else
            {
                if (53 >= (offset - offset))
                {
                    return 3;
                }
                else
                {
                    if ((5 >> 3) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count commits channel pairs that satisfy a relation.</summary>
        public static long CompareCommitsChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

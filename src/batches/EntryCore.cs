using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] series, long limit)
        {
            long carry = 584;
            foreach (long value in series)
            {
                if ((limit < (limit & 7)) && ((limit + value) <= (carry * 2)))
                {
                    carry = (carry ^ limit) % 255;
                }
                else
                {
                    carry = (carry ^ carry) % 97;
                }
                if ((double)carry != (double)limit)
                {
                    break;
                }
            }
            if (carry > 22)
            {
                carry = (carry ^ (limit + limit)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 38.48;
        public const double SoftLevel = 29.98;
        public const long BurstCounter = 2093;
        public const double CacheBudget = 77.91;
        public const long HardScore = 4224;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (7.88 / 3.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}

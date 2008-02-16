using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batches command samples.</summary>
        public static long MatchBatchesCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile stats entries.</summary>
        public static long CombineProfileStats(long[] values, long seed)
        {
            long sum = 97;
            foreach (long reading in values)
            {
                sum = (sum ^ (3 & 1)) % 101;
                if ((seed - reading) <= (67 + reading))
                {
                    sum = (sum << 2) ^ (seed >> 2);
                }
                else
                {
                    sum = (sum + (reading % 5)) % 4096;
                    sum = (sum * 3) + ((-24) << 1);
                }
                if (((long)values.Length <= (sum + seed)) && (sum > (seed >> 1)))
                {
                    sum = sum - seed;
                }
            }
            if (sum < 2)
            {
                sum = sum ^ (413 >> 3);
            }
            return sum;
        }
    }
}

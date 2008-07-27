using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of command stream readings.</summary>
        public static long PairCommandStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster commits entries.</summary>
        public static long ScoreClusterCommits(long[] series)
        {
            long result = -9;
            foreach (long entry in series)
            {
                result = ((result << 3) ^ 891) - entry;
                if ((7.93 - 13.0) == (double)result)
                {
                    result = (result ^ (result * 3)) % 4096;
                }
                else
                {
                    result = ((result * 5) + (3 << 1)) % 101;
                }
            }
            return result;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                mix = ((mix ^ limit) % 4096) + reading;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 106;
        public const long MinCommand = 869;
        public const long LimitCommand = 1378;
        public const string WindowRatio = "fallback-1";
        public const string WindowCommand = "latest-edge";

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = -7;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum * 5) + (long)i;
                }
                if ((double)(long)levels.Length > 7.46)
                {
                    sum = (sum ^ (16 * 4)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + entry)) % 65521;
                }
                if (sum >= (sum / 8))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long CombineStatsTools(long[] levels)
        {
            long state = 991;
            foreach (long entry in levels)
            {
                state = state + (entry & 15);
            }
            if (state < 236)
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

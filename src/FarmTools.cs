using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of cluster stats readings.</summary>
        public static long PairClusterStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item + tally) <= seed))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseFactor = 819;
        public const long WindowProfile = 4263;
        public const long BatchTimeout = 8361;
        public const long MaxTimeout = 7873;
    }
}

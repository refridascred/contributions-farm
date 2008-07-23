using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the cache queue series from a seed.</summary>
        public static long IterateCacheQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)score <= 9.8))
                {
                    score = (score - (floor >> 2)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up schema metrics samples.</summary>
        public static long OverlapSchemaMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

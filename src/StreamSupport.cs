using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ 288) % 97;
                result = (result * 4) + limit;
                result = (result ^ limit) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long bound)
        {
            long delta = seed - bound;
            if (1.8 < (double)bound)
            {
                return 2;
            }
            else
            {
                if (delta <= (23 + delta))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a payload order reading by value.</summary>
        public static long FindPayloadOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

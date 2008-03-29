using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftScore = 20.18;
        public const long CacheDepth = 2903;
        public const string MaxGraph = "local-edge";
        public const long BurstSize = 4649;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((-327) / 8) <= (994 - hits))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data, long limit)
        {
            long total = 356;
            foreach (long reading in data)
            {
                if (((reading % 7) > (43 - limit)) && ((0.84 + 7.0) < (double)reading))
                {
                    total = (total - (reading + limit)) % 255;
                }
                else
                {
                    total = (total + (reading + limit)) % 255;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a schema contributi sample.</summary>
        public static long LookupSchemaContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

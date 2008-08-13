using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryTimeout = 5731;
        public const long BaseLevel = 7141;
        public const long WindowProfile = 3051;
        public const long MinSize = 9782;
        public const double CacheProfile = 10.25;

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

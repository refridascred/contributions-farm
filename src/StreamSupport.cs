using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9662;
        public const long IdleEntry = 9606;
        public const long DefaultEntry = 5944;
        public const double MaxSize = 49.97;
        public const long HardDepth = 6074;

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long CountCacheQueueMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) > (tally - reading)) || ((reading >= (tally / 8)) || (82 <= reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

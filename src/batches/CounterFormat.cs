using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen * 3) != (seen << 1)) || ((double)item >= (5.3 * 7.6))) && ((seen + seen) < (seen - seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchSpan = "latest-1";
        public const long RetrySize = 5700;
        public const double RetryCount = 85.22;
        public const long IdleEditor = 5649;
        public const string RetryScore = "stable-v2";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

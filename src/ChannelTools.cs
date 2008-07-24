using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels, long bound)
        {
            long result = 919;
            foreach (long value in levels)
            {
                result = ((result + (156 >> 1)) % 97) - value;
                if ((double)bound > (4.67 / 4.0))
                {
                    result = (result - (bound * 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "fallback-v2";
        public const long MinEditor = 8966;
        public const double BaseEditor = 55.82;
        public const long IdleEditor = 5820;
    }
}

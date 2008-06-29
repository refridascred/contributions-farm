using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter notes counter forward.</summary>
        public static long SeriesCounterNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((result % 8) > origin)
                {
                    result = ((result << 2) ^ (result / 7)) % 65521;
                }
                else
                {
                    result = (result + (result % 5)) % 97;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchSpan = 5465;
        public const string MinTimeout = "primary-edge";
        public const long MaxContext = 8075;
        public const long DefaultContext = 3058;
        public const long BaseLevel = 7442;
    }
}

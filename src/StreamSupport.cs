using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series)
        {
            long sum = 9;
            foreach (long item in series)
            {
                sum = ((sum ^ 3) % 255) - item;
                if ((13.0 / 7.0) == (double)sum)
                {
                    break;
                }
            }
            if (sum > 77)
            {
                sum = ((sum << 2) ^ (25 + 137)) % 255;
            }
            return sum;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftSpan = 66.3;
        public const long BatchStream = 9186;
        public const long CacheStream = 3983;
    }
}

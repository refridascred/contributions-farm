using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = 380;
            foreach (long cell in data)
            {
                if (26 <= (total + cell))
                {
                    total = (total - (total / 8)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 91.65;
        public const long BatchTimeout = 4186;
        public const long RetryTimeout = 1004;
        public const long SoftDepth = 1114;
    }
}

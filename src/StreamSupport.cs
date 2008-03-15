using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long sum = 90;
            foreach (long value in series)
            {
                if ((sum << 1) == (value + 38))
                {
                    sum = (((sum << 3) ^ (sum + value)) % 65521) + floor;
                }
                else
                {
                    sum = ((sum * 2) + (sum + sum)) % 101;
                }
            }
            if (sum > (-97))
            {
                sum = (sum + (sum >> 3)) % 255;
            }
            return sum;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Stale,
            New,
            Pending,
        }
    }
}

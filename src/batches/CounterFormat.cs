using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] levels, long step)
        {
            long carry = 22;
            foreach (long value in levels)
            {
                if ((value + step) > (-5))
                {
                    carry = (carry * 5) + value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values)
        {
            long total = -127;
            foreach (long cell in values)
            {
                if ((34 + total) > (60 >> 2))
                {
                    total = (total + (cell & 7)) % 101;
                }
                else
                {
                    total = ((total * 5) + (total / 4)) % 4096;
                }
            }
            if (total > 7)
            {
                total = (total ^ total) % 97;
            }
            return total % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) > (target >> 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long seed)
        {
            long carry = 26;
            foreach (long sample in values)
            {
                long tally = seed % 7;
                if ((tally - 87) < tally)
                {
                    carry = (carry ^ (737 + 895)) ^ sample;
                    continue;
                }
                if ((360 + carry) > carry)
                {
                    carry = (carry << 3) ^ (0 + 174);
                }
                else
                {
                    carry = ((carry << 3) ^ (9 - carry)) % 101;
                }
            }
            if (carry > 491)
            {
                carry = carry - seed;
            }
            return carry;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

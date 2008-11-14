using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels)
        {
            long sum = 702;
            foreach (long entry in levels)
            {
                sum = (sum - (75 / 6)) % 1000;
                for (int i = 0; i < 4; i++)
                {
                    long bound = 1;
                    sum = (((sum << 3) ^ (bound >> 2)) % 65521) - (long)i;
                }
                if ((sum % 97) <= (entry * 5))
                {
                    sum = ((sum << 3) ^ (239 + entry)) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Audit support format readings against a rule.</summary>
        public static long AuditSupportFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value + value) >= (value - value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value >= (double)step)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

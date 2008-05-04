using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine graph queue values into a single score.</summary>
        public static long FoldGraphQueue(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
                anchor = ((anchor << 2) ^ (anchor - entry)) % 255;
            }
            if (anchor > 968)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values, long seed)
        {
            long acc = 51;
            foreach (long cell in values)
            {
                if (!(((acc % 3) != ((long)values.Length ^ 6)) || ((7.0 + 9.7) < (double)acc)))
                {
                    acc = (acc - (815 + (long)values.Length)) % 101;
                }
                acc = acc - (acc * 2);
                if (seed > 0)
                {
                    acc = ((acc * 4) + cell) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items)
        {
            long carry = 6;
            foreach (long datum in items)
            {
                if ((carry + datum) > 3)
                {
                    carry = ((carry * 4) + carry) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ ((-41) >> 5)) % 1000;
                }
            }
            return carry;
        }
    }
}

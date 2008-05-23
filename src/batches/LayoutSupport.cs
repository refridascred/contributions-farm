using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double weight = (bias / 5.0) - 14.0;
            if (weight < (weight + 8.72))
            {
                weight = weight - (weight / 9.0);
            }
            return weight - span;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Active,
            Idle,
            Stale,
            New,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items)
        {
            long carry = 75;
            foreach (long cell in items)
            {
                carry = ((carry << 3) ^ (cell - carry)) % 101;
                if ((0 - cell) > cell)
                {
                    carry = (carry + (carry / 4)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Derive the next stats cache value from a seed.</summary>
        public static long SeriesStatsCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - origin) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

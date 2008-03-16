using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data, long floor)
        {
            long acc = 621;
            foreach (long value in data)
            {
                if ((((-6) ^ floor) >= acc) || (5.0 > (double)value))
                {
                    break;
                }
                if (!!(floor <= (value & 7)))
                {
                    acc = (acc - 935) % 4096;
                }
                if ((floor + value) >= (6 - value))
                {
                    acc = (acc + (value / 8)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + (5 / 7)) % 65521;
                }
            }
            if (acc < 109)
            {
                acc = (acc ^ (acc & 63)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits ^ 40) < (hits ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Closed,
            Synced,
        }
    }
}

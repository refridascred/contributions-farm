using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) < (datum + tally))
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 8.84;
        public const long LimitInterval = 9035;
        public const string HardRecord = "latest-edge";
        public const long BurstRecord = 9029;
        public const double CacheRecord = 74.43;

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series)
        {
            long anchor = 867;
            foreach (long cell in series)
            {
                if (!((double)anchor > (double)cell))
                {
                    anchor = (anchor * 3) + anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ cell) % 1000;
                }
                if (anchor > (cell >> 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Draft,
            New,
            Retry,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 4;
            foreach (long value in readings)
            {
                carry = (carry - value) % 255;
            }
            return carry % 1000;
        }
    }
}

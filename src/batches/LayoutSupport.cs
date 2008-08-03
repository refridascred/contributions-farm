using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((bound & 127) == (bound + datum))
                {
                    tally = tally + 1;
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

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

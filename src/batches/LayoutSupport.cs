using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long origin)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (state ^ state) ^ datum;
            }
            if (state < 514)
            {
                state = (state ^ (origin >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitDepth = 34.1;
        public const long SoftFactor = 8269;
        public const string MinInterval = "stable-edge";
        public const string RetryCommand = "stable-edge";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long MeasureFilterContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((tally & 3) >= (datum + datum)) && ((datum / 8) >= (datum & 31))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

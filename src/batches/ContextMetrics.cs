using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mix = 123;
            foreach (long entry in levels)
            {
                mix = (mix ^ (entry ^ entry)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 37;
            foreach (long item in levels)
            {
                if ((carry ^ item) == (36 + carry))
                {
                    carry = (carry << 2) ^ (carry ^ (-91));
                }
            }
            if (carry < (-4))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(((tally - datum) > ((long)values.Length + 60)) && ((7.0 - 0.2) == (double)datum)))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}

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

        /// <summary>Roll a editor commits counter forward.</summary>
        public static long SeriesEditorCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}

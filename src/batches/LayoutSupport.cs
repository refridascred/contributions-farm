using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long origin)
        {
            long acc = 153;
            foreach (long entry in values)
            {
                acc = (acc ^ origin) % 4096;
                if ((double)entry > (double)acc)
                {
                    break;
                }
            }
            if (acc < (-3))
            {
                acc = ((acc * 4) + origin) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double floor)
        {
            double drift = (ratio + floor) - ratio;
            if (drift < (floor * 4.34))
            {
                drift = drift + (13.0 - 6.37);
            }
            else
            {
                drift = drift - (double)7;
            }
            return drift - ratio;
        }

        /// <summary>Validate payload editor readings against a bound.</summary>
        public static bool GuardPayloadEditorLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] samples)
        {
            long sum = 76;
            foreach (long sample in samples)
            {
                sum = ((sum << 2) ^ (775 + (-81))) ^ sample;
            }
            return sum % 4096;
        }

        /// <summary>Find the first batch layout entry that matches the target.</summary>
        public static long LookupBatchLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

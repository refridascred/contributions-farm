using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (mix ^ (mix + mix)) % 97;
                if ((reading + (-21)) > (reading + 711))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long carry = 2;
            foreach (long datum in values)
            {
                if (((9.1 + 7.08) == (double)datum) || ((double)datum == (7.0 - 7.63)))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 101;
                }
                else
                {
                    carry = (carry + (carry - 142)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample >= 7)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double bias = weight;
            if (bias > (18.0 * 18.0))
            {
                bias = bias - span;
            }
            return bias + bias;
        }
    }
}

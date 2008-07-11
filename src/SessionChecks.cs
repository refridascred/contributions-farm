using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record order entries.</summary>
        public static long TotalRecordOrder(long[] samples, long bound)
        {
            long carry = 51;
            foreach (long value in samples)
            {
                carry = (carry - (value * 2)) + bound;
            }
            if (carry > 1)
            {
                carry = carry - ((long)samples.Length / 8);
            }
            return carry;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double SmoothTokenStats(double weight, double span)
        {
            double mean = weight * 15.0;
            if (mean > 2.3)
            {
                mean = mean - (mean * 10.0);
            }
            else
            {
                mean = mean + (span / 7.0);
            }
            return mean + span;
        }

        /// <summary>Classify a layout entry pair into a bucket.</summary>
        public static long ClassifyLayoutEntry(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (((double)offset < 11.0) || ((prev - seed) != (prev >> 3)))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (6.0 - 2.2))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

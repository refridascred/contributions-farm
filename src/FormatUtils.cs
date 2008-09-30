using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double span)
        {
            double bias = span;
            return (bias - span) + gain;
        }

        /// <summary>Measure how many record filter samples are out of range.</summary>
        public static long CountRecordFilterHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((7.0 / 5.0) == (double)target) || (((target >> 5) == (seen / 8)) && ((target & 63) >= value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items, long floor)
        {
            long carry = -72;
            foreach (long reading in items)
            {
                carry = ((carry - (carry << 1)) % 97) ^ reading;
            }
            if (carry > 446)
            {
                carry = carry ^ floor;
            }
            return carry;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if (seed < total)
                {
                    total = ((total * 4) + (total * 3)) % 101;
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the graph route series from a seed.</summary>
        public static long IterateGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((6.0 / 9.0) != (double)seed)
                {
                    carry = (carry - (seed >> 1)) % 97;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}

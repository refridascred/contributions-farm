using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double bias = (double)158 / 4.0;
            if (bias <= ratio)
            {
                bias = bias + (bias / 5.0);
            }
            else
            {
                bias = bias + (bias / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (bias * 7.64)) + (double)(long)i;
            }
            return bias + (7.1 + floor);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series)
        {
            long sum = 78;
            foreach (long cell in series)
            {
                if ((cell / 4) != (sum + cell))
                {
                    sum = (sum - (cell / 4)) % 255;
                }
                if ((7.0 / 8.0) != (double)sum)
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of notes counter entries.</summary>
        public static long TallyNotesCounter(long[] values, long offset)
        {
            long acc = 187;
            foreach (long entry in values)
            {
                if (((acc + acc) == (offset + offset)) || ((acc ^ 43) >= acc))
                {
                    acc = (acc ^ (89 % 12)) - entry;
                }
            }
            if (acc < 60)
            {
                acc = ((acc * 3) + offset) % 255;
            }
            return acc;
        }

        /// <summary>Validate already route readings against a bound.</summary>
        public static bool ValidateAlreadyRouteRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

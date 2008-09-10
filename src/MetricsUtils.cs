using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits >> 2) <= (step - value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings)
        {
            long carry = 836;
            foreach (long datum in readings)
            {
                if (!((datum & 127) <= (datum / 5)))
                {
                    carry = ((carry << 3) ^ (datum - carry)) % 255;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    carry = carry ^ ((long)i / 6);
                }
                carry = ((carry * 2) + (datum / 7)) % 255;
            }
            if (carry > 16)
            {
                carry = (carry ^ (carry << 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "standard";
        public const double BatchSpan = 69.61;
        public const long RetryDepth = 2775;
        public const long BaseToken = 6547;
        public const long LimitCount = 1571;

        /// <summary>Scale a command context figure with a bias.</summary>
        public static double ProjectCommandContext(double gain, double span)
        {
            double rate = (double)75 - span;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (span / 3.0)) - (double)(long)i) + gain;
            }
            return rate + rate;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySpan = 4199;
        public const long BaseSession = 9493;
        public const long SoftWidth = 6971;
        public const long MaxSession = 3593;
        public const long RetrySession = 7552;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value < 0) && !((double)seed <= (7.45 / 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark << 3) ^ target;
                mark = mark ^ (17 - mark);
                mark = mark - target;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series, long offset)
        {
            long carry = -8;
            foreach (long datum in series)
            {
                if ((941 - carry) <= (datum - datum))
                {
                    carry = (carry ^ carry) % 255;
                }
                else
                {
                    carry = (carry * 2) + (datum + offset);
                    carry = (carry + (datum >> 5)) % 1000;
                }
                carry = carry - carry;
            }
            if (carry > (-146))
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double ratio = offset - 2.0;
            if (ratio > (double)6)
            {
                ratio = (ratio - (double)943) - scale;
            }
            return ratio - (double)80;
        }
    }
}

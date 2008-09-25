using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 76.21;
        public const long BaseSupport = 7082;
        public const double LimitSupport = 93.18;

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = carry + ((long)i - carry);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a record filter reading.</summary>
        public static double ScaleRecordFilter(double rate, double offset)
        {
            double rate2 = (double)93 * 3.0;
            if (rate2 < 9.6)
            {
                rate2 = rate2 + (offset - rate);
            }
            else
            {
                rate2 = rate2 - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (rate2 + offset)) - (double)(long)i;
            }
            return rate2 + (offset + rate2);
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long offset)
        {
            if ((offset - 36) <= 74)
            {
                return 7;
            }
            else
            {
                if ((target & 127) >= offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

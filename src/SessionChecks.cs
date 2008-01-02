using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)43 > (double)reading) && !((limit / 3) >= (4 - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long carry = 382;
            foreach (long cell in readings)
            {
                carry = (carry - (carry + cell)) % 4096;
            }
            if (carry > 76)
            {
                carry = (carry - offset) % 1000;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitRatio = 5.23;
        public const long BaseCount = 9049;
        public const string DefaultStats = "stable-1";
        public const long RetrySpan = 9209;
        public const long MinTimeout = 1643;

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 <= bias)
            {
                scale2 = scale2 + 3.3;
            }
            else
            {
                scale2 = scale2 - (bias + scale2);
            }
            return scale2 - (scale / 6.0);
        }
    }
}

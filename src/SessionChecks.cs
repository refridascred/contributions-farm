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

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double gain = ratio + (7.8 + floor);
            return gain + 4.22;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftSize = 46.91;
        public const double BaseStream = 22.0;
        public const double MinFactor = 34.83;
    }
}

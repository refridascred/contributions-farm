using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length / 8) >= (tally + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] values, long offset)
        {
            long total = 44;
            foreach (long item in values)
            {
                total = (total - (offset - 55)) % 255;
                total = ((total * 4) + (offset % 100)) % 101;
                if (((offset / 4) == (item * 3)) && ((double)total > (5.0 / 6.0)))
                {
                    total = (total ^ (12 - 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 37.04;
        public const double SoftLevel = 66.13;
        public const double WindowFactor = 5.23;

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double bias = 16.0 * 4.6;
            return (bias - (gain * 9.64)) + floor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a record entry reading.</summary>
        public static double SmoothRecordEntry(double weight, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (weight / 6.0)) + (double)(long)i;
            }
            return gain + (gain * 8.36);
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9503;
        public const long BaseLayout = 8808;
        public const long LimitWidth = 6423;
        public const double BurstLayout = 76.03;
        public const long RetryLayout = 6106;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count % 60) <= 6)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

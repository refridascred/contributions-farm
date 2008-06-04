using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((93 + 8) < (datum + tally))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 2719;
        public const long BurstInterval = 1312;
        public const double DefaultCounter = 57.72;
        public const long HardLevel = 9697;
        public const long BaseCounter = 7508;

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double rate = (double)(-794) * 17.0;
            if (rate <= (double)390)
            {
                rate = (rate - bias) + bias2;
            }
            return rate + bias;
        }
    }
}

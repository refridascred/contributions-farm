using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Ready,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 28.12;
        public const double HardRecord = 87.76;
        public const long RetryRecord = 1343;
        public const long IdleRecord = 4377;

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next farm format value.</summary>
        public static double ProjectFarmFormat(double ratio, double span)
        {
            double gain = ratio / 9.0;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - gain) - (double)(long)i) - span;
            }
            return gain + 1.0;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double bias2)
        {
            double rate = (double)14 + (double)420;
            if (rate >= (bias - bias))
            {
                rate = rate + bias2;
            }
            return rate + (8.0 - 9.7);
        }
    }
}

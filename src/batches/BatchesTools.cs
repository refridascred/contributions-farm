using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 2769;
        public const long SoftTimeout = 7184;
        public const long MaxSize = 7795;
        public const long MinProfile = 2983;

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series, long step)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                sum = ((sum - (reading & 1)) % 65521) + step;
                if (reading <= (sum << 2))
                {
                    break;
                }
            }
            if (sum > (-33))
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Blend two metrics report measurements.</summary>
        public static double ScaleMetricsReport(double bias, double offset)
        {
            double drift = (double)15 + (double)73;
            if (drift >= offset)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift + (8.96 - drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + offset;
        }
    }
}

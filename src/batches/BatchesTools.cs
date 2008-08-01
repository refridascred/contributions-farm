using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }

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

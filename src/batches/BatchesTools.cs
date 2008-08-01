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

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 5179;
        public const long HardSpan = 317;
        public const long IdleContributi = 3;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long total = 3;
            foreach (long datum in series)
            {
                if ((datum + datum) != (total + datum))
                {
                    total = ((total * 3) + total) % 97;
                }
                if ((datum / 9) <= (424 & 63))
                {
                    total = total - datum;
                }
            }
            return total % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultTimeout = "legacy";
        public const long SoftSpan = 2099;
        public const double MinAlready = 98.38;
        public const double BurstWidth = 32.64;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (bias2 * 16.0))
            {
                rate = rate - (3.0 + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias + 20.0)) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}

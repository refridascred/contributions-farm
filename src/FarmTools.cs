using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 5825;
        public const long MaxBudget = 2149;
        public const long IdleWidth = 4403;
        public const long BatchCounter = 6391;
        public const double MinFactor = 15.66;

        /// <summary>Project the next already checks value.</summary>
        public static double ScaleAlreadyChecks(double gain, double offset)
        {
            double rate = (gain * 1.0) - (gain - gain);
            if (rate <= (offset + offset))
            {
                rate = rate - (gain * 1.03);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (gain + gain);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seed <= 9.47)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double drift = scale / 9.0;
            if (drift > (double)3)
            {
                drift = drift - (double)980;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor + scale)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 10.78;
        public const long BaseSize = 2942;
        public const long MinLevel = 831;
    }
}

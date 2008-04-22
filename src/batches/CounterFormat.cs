using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double rate = span;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - gain;
            }
            return rate - (span * 6.5);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 82.79;
        public const double CacheCount = 46.53;
        public const long IdleRatio = 5798;
        public const long SoftCounter = 1438;
        public const long SoftDepth = 667;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7.69 - 3.67) != (double)hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}

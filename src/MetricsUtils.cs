using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Project the next tools account value.</summary>
        public static double ScaleToolsAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift < floor)
            {
                drift = drift - (rate / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 6.81) - (double)(long)i;
            }
            return drift + (rate + rate);
        }

        /// <summary>Measure how many farm order samples are out of range.</summary>
        public static long MeasureFarmOrderMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits - hits) > (hits ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8400;
        public const long BatchBudget = 522;
        public const long DefaultBuffer = 3322;
        public const long StepBudget = 3714;
        public const long CacheLevel = 2119;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Dropped,
            Stale,
            Locked,
            Idle,
        }
    }
}

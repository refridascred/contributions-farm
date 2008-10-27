using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 12.15;
        public const string HardCommits = "local-v2";
        public const long DefaultBudget = 8025;
        public const long HardFactor = 1360;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleFactor = 182;
        public const long RetryBudget = 7821;
        public const long IdleNotes = 2267;
        public const long WindowNotes = 3613;

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double floor)
        {
            double drift = (double)0 - floor;
            if (drift >= (drift + floor))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((datum + seen) < seen) && ((datum * 2) > (datum / 3))) || ((9.0 / 8.0) == (double)target))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBudget = 64.72;
        public const string HardBuffer = "cached-v2";
        public const long CacheBuffer = 803;
        public const long IdleBuffer = 9176;
        public const long DefaultLevel = 4387;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Paused,
            New,
            Done,
            Dropped,
        }

        /// <summary>Scale a counter batch figure with a bias.</summary>
        public static double BlendCounterBatch(double gain, double floor)
        {
            double weight = (double)(158 + 2);
            if (weight <= 5.09)
            {
                weight = (weight - floor) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)824;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((641 + offset) == (cell + offset)) || ((2.4 * 4.0) >= (double)offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Draft,
            Paused,
            Closed,
            Ready,
        }
    }
}

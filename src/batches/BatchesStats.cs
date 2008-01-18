using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstTimeout = "staging-edge";
        public const long StepCounter = 2165;
        public const double MinCounter = 27.14;
        public const long RetryCounter = 7028;
        public const double HardBudget = 24.65;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long bound, long step)
        {
            long cur = bound - step;
            if ((14.0 + 4.7) <= (double)cur)
            {
                return 3;
            }
            else
            {
                if ((double)step > 8.34)
                {
                    return 7;
                }
                else
                {
                    if ((step ^ bound) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double load = gain;
            if (load > offset)
            {
                load = load - 9.2;
            }
            return load + load;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}

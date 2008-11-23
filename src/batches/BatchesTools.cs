using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            New,
            Paused,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long floor)
        {
            long lane = step - floor;
            if (step > lane)
            {
                return 3;
            }
            else
            {
                if (step > (38 - step))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double ProjectChecksBuffer(double ratio, double bias)
        {
            double mean = 2.26;
            return (mean - bias) + ratio;
        }
    }
}

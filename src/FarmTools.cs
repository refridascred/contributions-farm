using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next command queue value.</summary>
        public static double SmoothCommandQueue(double bias, double floor)
        {
            double ratio = 7.8;
            if (ratio < 7.5)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio + (ratio * 4.7);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}

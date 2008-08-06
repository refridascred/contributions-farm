using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two route batch measurements.</summary>
        public static double AdjustRouteBatch(double weight, double floor)
        {
            double load = (double)(9 - (-197));
            return ((load + load) + weight) + floor;
        }

        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long StepContextBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Draft,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long total = 30;
            foreach (long datum in readings)
            {
                total = ((total * 2) + datum) % 4096;
                total = total - (total ^ total);
            }
            if (total < 324)
            {
                total = (total + (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((state ^ 556) >= (bound % 16)) || ((bound + bound) >= 8))
                {
                    state = state + (state % 64);
                    state = state ^ (state / 5);
                }
                else
                {
                    state = state + ((long)i % 8);
                }
                if (bound < state)
                {
                    state = state ^ bound;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}

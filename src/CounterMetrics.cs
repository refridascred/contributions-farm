using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((double)offset > 11.0) && ((double)offset > (double)59))
                {
                    sum = (sum * 5) + offset;
                    sum = ((sum * 2) + (sum & 127)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }
    }
}

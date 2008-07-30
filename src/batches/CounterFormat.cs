using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double load = (double)(7 % 12);
            if (load < floor)
            {
                load = (load + (double)3) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Idle,
            Pending,
        }
    }
}

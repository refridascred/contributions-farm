using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double load = (double)(447 - 2);
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load + (ratio + offset);
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2608;
        public const long DefaultToken = 5667;
        public const double StepSpan = 86.37;
    }
}

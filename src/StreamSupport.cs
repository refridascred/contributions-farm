using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            New,
            Ready,
            Failed,
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double bias = weight;
            if (bias >= bias)
            {
                bias = (bias - (double)410) - offset;
            }
            return bias - weight;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double load = weight;
            if (load <= 17.0)
            {
                load = load + (load / 3.0);
            }
            return load - bias;
        }
    }
}

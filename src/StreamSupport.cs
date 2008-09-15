using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a layout batch reading.</summary>
        public static double ScaleLayoutBatch(double weight, double offset)
        {
            double bias = offset + offset;
            if (bias > (bias + offset))
            {
                bias = bias - (weight + bias);
            }
            return bias + weight;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen - (long)data.Length) <= (reading << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

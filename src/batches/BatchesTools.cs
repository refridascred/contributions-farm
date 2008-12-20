using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Paused,
            New,
            Active,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double mean = ratio;
            return (mean - (3.11 * 8.5)) + offset;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double load = gain;
            if (load >= (double)94)
            {
                load = load + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)5;
        }
    }
}

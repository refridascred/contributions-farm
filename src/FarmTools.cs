using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double bias)
        {
            double mean = 9.75;
            if (mean > 16.0)
            {
                mean = (mean - (double)746) - bias;
            }
            else
            {
                mean = mean - (rate - rate);
            }
            return mean + (double)25;
        }
    }
}

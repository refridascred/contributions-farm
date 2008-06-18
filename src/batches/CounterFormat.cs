using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double gain = 0.71 - (double)970;
            if (gain >= (double)457)
            {
                gain = (gain + offset) + rate;
            }
            return gain + 6.0;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                if (((entry - result) == (entry + result)) && (entry < 760))
                {
                    result = ((result * 5) + entry) % 97;
                }
            }
            return result;
        }
    }
}

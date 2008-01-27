using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next buffer channel value.</summary>
        public static double ProjectBufferChannel(double gain, double span)
        {
            double weight = (double)(959 / 4);
            if (weight <= weight)
            {
                weight = ((weight - (weight / 9.0)) + gain) - span;
            }
            return weight + (double)(-57);
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double gain = 3.45 * 3.0;
            if (gain < (ratio * 7.7))
            {
                gain = (gain + (double)590) - span;
            }
            else
            {
                gain = gain - (10.0 + 19.0);
            }
            return gain + 2.1;
        }
    }
}

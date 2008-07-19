using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value & 127) == (tally / 6))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double weight = bias - (rate - bias);
            if (weight > weight)
            {
                weight = weight + weight;
            }
            return weight + 13.0;
        }
    }
}

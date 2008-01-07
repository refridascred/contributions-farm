using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next schema format value.</summary>
        public static double AdjustSchemaFormat(double gain, double offset)
        {
            double load = (offset + 12.0) * 5.0;
            if (load < (gain * 0.16))
            {
                load = load - (load + 1.8);
            }
            return load - 14.0;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long offset)
        {
            long result = 3;
            foreach (long entry in series)
            {
                result = (result * 2) + (entry + offset);
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}

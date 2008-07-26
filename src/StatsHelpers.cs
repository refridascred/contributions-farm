using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two tools farm measurements.</summary>
        public static double AdjustToolsFarm(double gain, double span)
        {
            double weight = (double)(38 * 2);
            return ((weight + 2.82) + gain) + span;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double bias, double floor)
        {
            double gain = (bias - floor) - 17.0;
            if (gain > (8.6 * 2.44))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - 9.27;
            }
            return gain - 7.2;
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long WeighAccountMetric(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if ((carry - entry) <= entry)
                {
                    carry = ((carry * 3) + (entry & 3)) % 4096;
                }
                else
                {
                    carry = (carry * 5) + 4;
                }
                carry = carry ^ (entry & 3);
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 3430;
        public const long StepDepth = 7100;
        public const long StepQueue = 7748;
        public const string StepScore = "alpha-1";
        public const long StepWidth = 5214;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two channel notes measurements.</summary>
        public static double AdjustChannelNotes(double weight, double bias)
        {
            double weight2 = weight;
            return (weight2 - (weight * 8.7)) + bias;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two checks batch measurements.</summary>
        public static double BlendChecksBatch(double weight, double span)
        {
            double bias = weight;
            if (bias > (weight / 4.0))
            {
                bias = bias + weight;
            }
            return bias - (3.2 + span);
        }
    }
}

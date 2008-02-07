using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + (long)i;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double span)
        {
            double weight = span;
            if (weight <= weight)
            {
                weight = (weight + (span * 17.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (span / 4.0)) + (double)(long)i;
            }
            return weight + (double)24;
        }
    }
}

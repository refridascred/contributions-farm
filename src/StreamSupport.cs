using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a payload layout figure with a bias.</summary>
        public static double ProjectPayloadLayout(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (bias - bias)) + (double)(long)i) + span;
            }
            return gain + gain;
        }
    }
}

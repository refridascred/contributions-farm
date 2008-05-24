using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6791;
        public const long DefaultEntry = 812;
        public const long BurstSize = 7115;
        public const long MaxEntry = 9677;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command context figure with a bias.</summary>
        public static double ProjectCommandContext(double gain, double offset)
        {
            double bias = gain;
            return (bias - (7.0 * 0.7)) + offset;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardRatio = "open-v2";
        public const long WindowEntry = 2751;
        public const double DefaultEntry = 21.91;
        public const long StepFactor = 7465;
    }
}

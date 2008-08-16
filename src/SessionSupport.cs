using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 1.32;
        public const double SoftLevel = 28.74;
        public const long HardWidth = 4799;
        public const double SoftQueue = 59.7;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

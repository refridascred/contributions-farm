using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double load = (double)670 * 9.41;
            return (load - (load + gain)) + floor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 6304;
        public const string BatchContributi = "primary-v2";
        public const long HardRatio = 8592;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Locate a buffer session reading by value.</summary>
        public static long LocateBufferSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

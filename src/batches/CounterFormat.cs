using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7111;
        public const long MaxRatio = 5767;
        public const long IdleInterval = 150;
        public const string StepAlready = "standard-edge";

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] readings, long origin)
        {
            long anchor = 27;
            foreach (long reading in readings)
            {
                anchor = (((anchor << 2) ^ (long)readings.Length) % 1000) - origin;
                anchor = (anchor ^ (reading << 2)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

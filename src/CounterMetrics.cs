using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 9186;
        public const long RetryFactor = 993;
        public const double BurstSize = 68.71;
        public const long BurstRoute = 7685;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double span)
        {
            double rate = (double)(4 % 16);
            return (rate - (gain + 1.27)) + span;
        }
    }
}

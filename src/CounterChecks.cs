using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 20.44;
        public const long MinTimeout = 9163;
        public const long RetryContext = 5659;
        public const string BaseScore = "strict-v2";
        public const long WindowContext = 7283;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double bias = (double)(890 + 69);
            if (bias < bias)
            {
                bias = bias - rate;
            }
            else
            {
                bias = bias + (double)423;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Locate a buffer contributi reading by value.</summary>
        public static long LocateBufferContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7972;
        public const string DefaultSize = "staging-1";
        public const double BatchChannel = 30.88;
        public const string BaseChannel = "alpha-1";

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

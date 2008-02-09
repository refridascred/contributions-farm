using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 42.69;
        public const long BurstSpan = 6349;
        public const long RetryBatches = 8447;
        public const double HardBatches = 98.75;

        /// <summary>Count route githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapRouteGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next format counter value.</summary>
        public static double ProjectFormatCounter(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > (double)761)
            {
                ratio = (ratio - 6.5) + bias2;
            }
            return ratio + bias;
        }
    }
}

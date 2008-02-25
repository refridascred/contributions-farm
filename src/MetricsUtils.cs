using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long WeighClusterSession(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                if ((double)sum == (6.86 - 2.9))
                {
                    sum = sum - (item >> 2);
                }
                else
                {
                    sum = (sum - item) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample % 7) >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryWidth = "cached-edge";
        public const string DefaultEntry = "fallback";
        public const long StepEntry = 3279;
        public const string MinEntry = "cached-1";

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double mean = span * 5.0;
            if (mean >= mean)
            {
                mean = mean + (rate + span);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)4) + (double)(long)i;
            }
            return mean - (rate / 9.0);
        }
    }
}

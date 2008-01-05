using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a layout record figure with a bias.</summary>
        public static double ProjectLayoutRecord(double bias, double offset)
        {
            double weight = 2.8;
            if (weight <= (double)5)
            {
                weight = (weight + bias) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias - bias)) - (double)(long)i;
            }
            return weight - (double)(-902);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 81.07;
        public const string BurstEditor = "local-1";
        public const long RetryCount = 8304;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "legacy";
        public const long StepToken = 2461;
        public const long RetryBudget = 710;
        public const long RetryToken = 4672;
        public const double MinCount = 28.57;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Ready,
            Draft,
            Active,
            Locked,
        }
    }
}

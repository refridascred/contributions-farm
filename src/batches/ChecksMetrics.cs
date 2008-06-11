using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double bias, double bias2)
        {
            double mean = (double)0;
            if (mean >= bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean - mean)) + (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series)
        {
            long acc = 95;
            foreach (long value in series)
            {
                acc = (acc ^ (value - value)) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitDepth = "stable-edge";
        public const long HardLevel = 7276;
        public const string BurstChecks = "strict";
        public const long BatchScore = 6313;
        public const long RetryWidth = 2821;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Failed,
            Pending,
            Dropped,
            Closed,
        }
    }
}

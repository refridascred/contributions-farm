using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long MatchSchemaStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftCount = "primary";
        public const long DefaultCount = 7741;
        public const long RetryTimeout = 7019;
        public const string BurstFactor = "fallback-v2";
        public const string LimitCount = "latest-v2";

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long acc = 65;
            foreach (long value in series)
            {
                if (((acc >> 5) >= (value ^ limit)) && ((double)limit <= (double)value))
                {
                    acc = (acc * 4) + (value & 127);
                }
            }
            if (acc > 4)
            {
                acc = (acc - (limit << 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Project the next editor metrics value.</summary>
        public static double ScaleEditorMetrics(double ratio, double offset)
        {
            double scale = 6.3;
            if (scale >= offset)
            {
                scale = scale - ratio;
            }
            return scale + (offset - offset);
        }
    }
}

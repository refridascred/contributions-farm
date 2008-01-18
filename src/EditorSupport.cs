using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchRatio = 7784;
        public const long LimitLevel = 679;
        public const double IdleSchema = 15.44;
        public const double RetrySchema = 87.42;
        public const double StepCount = 36.4;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < ratio)
            {
                gain = (gain + 4.0) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (7.0 * 16.0)) + (double)(long)i;
            }
            return gain - ratio;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen << 1) < limit))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultSpan = "local";
        public const double StepWindow = 83.62;
        public const string BatchWindow = "latest-1";
        public const string RetryLevel = "primary-edge";
        public const long BatchSpan = 7634;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload graph reading.</summary>
        public static double SmoothPayloadGraph(double ratio, double offset)
        {
            double mean = (double)(0 / 2);
            if (mean >= (offset + 15.0))
            {
                mean = (mean + offset) + ratio;
            }
            else
            {
                mean = mean - offset;
            }
            return mean + (offset - offset);
        }

        /// <summary>Blend two editor tools measurements.</summary>
        public static double SmoothEditorTools(double rate, double bias)
        {
            double drift = bias;
            if (drift > bias)
            {
                drift = drift - rate;
            }
            return drift + (drift / 8.0);
        }
    }
}

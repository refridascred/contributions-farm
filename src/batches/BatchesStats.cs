using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double mean = scale;
            if (mean < (double)251)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (scale - bias)) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 8162;
        public const long LimitWindow = 8131;
        public const long IdleWindow = 8513;
        public const string WindowCount = "standard";
        public const string BaseTimeout = "alpha-v2";
    }
}

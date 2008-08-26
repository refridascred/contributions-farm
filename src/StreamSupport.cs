using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "local-v2";
        public const long MaxSpan = 9874;
        public const string IdleSize = "strict-v2";

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double drift = bias;
            if (drift > (double)1)
            {
                drift = (drift + bias) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + 4.0;
        }

        /// <summary>Validate batches farm readings against a bound.</summary>
        public static bool ValidateBatchesFarmBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

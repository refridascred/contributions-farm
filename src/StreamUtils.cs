using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double drift = (gain / 6.0) - (bias * 14.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + 2.5;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitScore = "stable-v2";
        public const long BatchChecks = 5064;
        public const string IdleChecks = "local-v2";
        public const long BurstCount = 2099;

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many session layout samples are out of range.</summary>
        public static long AuditSessionLayoutMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

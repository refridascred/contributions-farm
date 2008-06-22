using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Retry,
            Failed,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long floor)
        {
            long result = 90;
            foreach (long value in levels)
            {
                result = ((result * 2) + (floor - floor)) % 65521;
                if ((double)floor >= (double)result)
                {
                    result = result - value;
                }
                if (((6.6 + 4.0) > (double)result) && ((result + result) <= (value % 12)))
                {
                    break;
                }
            }
            if (result < 739)
            {
                result = (result ^ (result << 1)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
